using DTO.Schemas;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DAL
{
	public class NBL_DAL
	{
		private readonly IMongoCollection<Bus> bus_collection;
		private readonly IMongoCollection<Driver> driver_collection;
		private readonly IMongoCollection<School> school_collection;
		private readonly IMongoCollection<Region> region_collection;
		private readonly IMongoCollection<Student> student_collection;
		private readonly IMongoCollection<Trip> trip_collection;

		public NBL_DAL()
		{
			var database = Database.Instance.GetDatabase();
			
			bus_collection = database.GetCollection<Bus>("Bus");
			driver_collection = database.GetCollection<Driver>("Driver");
			school_collection = database.GetCollection<School>("School");
			region_collection = database.GetCollection<Region>("Region");
			student_collection = database.GetCollection<Student>("Student");
			trip_collection = database.GetCollection<Trip>("Trip");
		}

		public List<Trip> getTripsWithDetails()
		{
			List<Trip> trips = trip_collection.Find(_ => true).ToList();

			return withDetails(trips);
		}

		public List<Trip> withDetails(List<Trip> trips)
		{
			foreach (Trip trip in trips)
			{
				trip.BusObj = bus_collection.Find(b => b.Id == trip.Bus).FirstOrDefault();
				trip.DriverObj = driver_collection.Find(d => d.Id == trip.Driver).FirstOrDefault();
				trip.SchoolObj = school_collection.Find(s => s.Id == trip.School).FirstOrDefault();
				trip.RegionObj = region_collection.Find(r => r.Id == trip.Region).FirstOrDefault();
				trip.StudentsObj = student_collection
					.Find(s => trip.Students.Contains(s.Id))
					.ToList();
			}

			return trips;
		}

		public List<Bus> getBusesBasedOnDate(DateTime date)
		{
			var trips_on_date = trip_collection
				.Find(t => t.Date >= date.Date && t.Date < date.Date.AddDays(1))
				.ToList();

			var used_buses_id = trips_on_date.Select(t => t.Bus).ToList();

			var avaiable_buses = bus_collection
				.Find(b => !used_buses_id.Contains(b.Id))
				.ToList();

			return avaiable_buses;
		}

		public List<Driver> getDriversBasedOnDate(DateTime date)
		{
			var trips_on_date = trip_collection
				.Find(t => t.Date >= date.Date && t.Date < date.Date.AddDays(1))
				.ToList();

			var used_drivers_id = trips_on_date.Select(t => t.Driver).ToList();

			var avaiable_drivers = driver_collection
				.Find(d => !used_drivers_id.Contains(d.Id))
				.ToList();

			return avaiable_drivers;
		}

		public int insertTrip(Trip trip)
		{
			var start = trip.Date.Date;
			var end = trip.Date.Date.AddDays(1).AddTicks(-1);

			var existing_bus = trip_collection.Find(t => t.Date >= start && t.Date <= end && t.Bus == trip.Bus).FirstOrDefault();
			if (existing_bus != null)
			{
				return -2;
			}

			var existing_driver = trip_collection.Find(t => t.Date >= start && t.Date <= end && t.Driver == trip.Driver).FirstOrDefault();
			if (existing_driver != null)
			{
				return -1;
			}

			var existing_bus_other = trip_collection.Find(t => t.Date == trip.Date && t.Bus == trip.Bus).FirstOrDefault();

			if (existing_bus_other != null)
			{
				return -2;
			}

			var existing_driver_other = trip_collection.Find(t => t.Date == trip.Date && t.Driver == trip.Driver).FirstOrDefault();

			if (existing_driver_other != null)
			{
				return -1;
			}

			trip_collection.InsertOne(trip);
			return 1;
		}



		public bool deleteTrip(ObjectId id)
		{
			var result = trip_collection.DeleteOne(t => t.Id == id);

			return result.DeletedCount > 0;
		}

		public int updateTrip(Trip trip)
		{
			var start = trip.Date.Date;
			var end = trip.Date.Date.AddDays(1).AddTicks(-1);

			var existing_bus = trip_collection.Find(t => t.Date >= start && t.Date <= end && t.Bus == trip.Bus).FirstOrDefault();
			if (existing_bus != null)
			{
				return -2;
			}

			var existing_driver = trip_collection.Find(t => t.Date >= start && t.Date <= end && t.Driver == trip.Driver).FirstOrDefault();
			if (existing_driver != null)
			{
				return -1;
			}

			var existing_bus_other = trip_collection.Find(t => t.Date == trip.Date && t.Bus == trip.Bus).FirstOrDefault();

			if (existing_bus_other != null)
			{
				return -2;
			}

			var existing_driver_other = trip_collection.Find(t => t.Date == trip.Date && t.Driver == trip.Driver).FirstOrDefault();

			if (existing_driver_other != null)
			{
				return -1;
			}

			var update_data = Builders<Trip>.Update
				.Set(t => t.Date, trip.Date)
				.Set(t => t.Bus, trip.Bus)
				.Set(t => t.Driver, trip.Driver)
				.Set(t => t.School, trip.School)
				.Set(t => t.Region, trip.Region)
				.Set(t => t.Students, trip.Students)
				.Set(t => t.Price, trip.Price)
				.Set(t => t.Status, trip.Status);

			var result = trip_collection.UpdateOne(t => t.Id == trip.Id, update_data);

			if(result.ModifiedCount > 0)
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}

		public bool cancelTrip(ObjectId id)
		{
			var trip = findTripById(id);

			if (trip == null)
			{
				return false;
			}

			var update = Builders<Trip>.Update.Set(t => t.Status, "cancelled");

			var result = trip_collection.UpdateOne(t => t.Id == id, update);

			return result.ModifiedCount > 0;
		}

		public Trip findTripById(ObjectId id)
		{
			return trip_collection.Find(t => t.Id == id).FirstOrDefault();
		}

		public List<Student> autoAddStudents(string region, string school, int limit, DateTime date)
		{
			var regions = region_collection.Find(r => r.Id == ObjectId.Parse(region)).FirstOrDefault();
			if (regions == null)
			{
				return null;
			}

			var students_id_in_region = regions.Students;

			var schools = school_collection.Find(s => s.Id == ObjectId.Parse(school)).FirstOrDefault();
			if (schools == null)
			{
				return null;
			}

			var trips_on_date = trip_collection
				.Find(t => t.Date >= date.Date && t.Date < date.Date.AddDays(1))
				.ToList();

			var students_in_trip = trips_on_date
				.SelectMany(t => t.Students)
				.ToList();

			var students_in_region_and_school = student_collection
				.Find(s => students_id_in_region.Contains(s.Id) &&
						   s.School == ObjectId.Parse(school) &&
						   !students_in_trip.Contains(s.Id) &&
						   s.Schedules.Contains(date.ToString("yyyy-MM-dd")))
				.Limit(limit)
				.ToList();

			return students_in_region_and_school;
		}


		public List<Trip> getTripsFilteredByDate(DateTime date)
		{
			var start_of_day = date.Date;
			var end_of_day = date.Date.AddDays(1).AddTicks(-1);

			return withDetails(trip_collection.Find(t => t.Date >= start_of_day && t.Date <= end_of_day).ToList());
		}

		public List<Trip> getTripsFilteredByDriver(string driver)
		{
			return withDetails(trip_collection.Find(t => t.Driver == ObjectId.Parse(driver)).ToList());
		}

		public List<Trip> getTripsFilteredByBus(string bus)
		{
			return withDetails(trip_collection.Find(t => t.Bus == ObjectId.Parse(bus)).ToList());
		}

		public List<Trip> getTripsFilteredBySchool(string school)
		{
			return withDetails(trip_collection.Find(t => t.School == ObjectId.Parse(school)).ToList());
		}

		public List<Trip> getTripsFilteredByRegion(string region)
		{
			return withDetails(trip_collection.Find(t => t.Region == ObjectId.Parse(region)).ToList());
		}

		public List<Trip> getTripsFilteredByPrice(double min_price, double max_price)
		{
			return withDetails(trip_collection.Find(t => t.Price >= min_price && t.Price <= max_price).ToList());
		}

		public List<Trip> getTripsFilteredByNumberOfStudents(int min_student, int max_student)
		{
			return withDetails(trip_collection.Find(t => t.Students.Count >= min_student && t.Students.Count <= max_student).ToList());
		}

		public List<Trip> getTripsFilteredByStatus(string type)
		{
			var allTrips = trip_collection.Find(t => t.Status == "active" || t.Status == "cancelled").ToList();

			DateTime today = DateTime.Now.Date;

			if (type == "Lên Kế Hoạch")
			{
				return withDetails(allTrips.Where(t => t.Status == "active" && t.Date.Date > today).ToList());
			}
			else if (type == "Đang Chạy")
			{
				return withDetails(allTrips.Where(t => t.Status == "active" && t.Date.Date == today).ToList());
			}
			else if (type == "Hoàn Thành")
			{
				return withDetails(allTrips.Where(t => t.Status == "active" && t.Date.Date < today).ToList());
			}
			else if (type == "Đã Hủy")
			{
				return withDetails(allTrips.Where(t => t.Status == "cancelled").ToList());
			}

			return new List<Trip>();
		}

		public Bus findBusById(string id)
		{
			return bus_collection.Find(b => b.Id == ObjectId.Parse(id)).FirstOrDefault();
		}

		public List<Bus> getBuses()
		{
			return bus_collection.Find(_ => true).ToList();
		}

		public List<Driver> getDrivers()
		{
			return driver_collection.Find(_ => true).ToList();
		}

		public List<School> getSchools()
		{
			return school_collection.Find(_ => true).ToList();
		}

		public List<Region> getRegions()
		{
			return region_collection.Find(_ => true).ToList();
		}

		public List<Student> getStudents()
		{
			return student_collection.Find(_ => true).ToList();
		}

		public Student getStudentById(ObjectId id)
		{
			return student_collection.Find(s => s.Id == id).FirstOrDefault();
		}

	}
}
