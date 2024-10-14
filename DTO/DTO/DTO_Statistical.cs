using DTO.Schemas;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DTO.DTO
{
    public class DTO_Statistical
    {

        protected readonly IMongoCollection<Trip> _collectionTrip;
        protected readonly IMongoCollection<Bus> _collectionBus;
        protected readonly IMongoCollection<Driver> _collectionDriver;

        public IMongoDatabase _database = Database.Instance.GetDatabase();
        CultureInfo cultureInfo = new CultureInfo("vi-VN");
        public DTO_Statistical()
        {
            _collectionTrip = _database.GetCollection<Trip>("Trip");
            _collectionBus = _database.GetCollection<Bus>("Bus");
            _collectionDriver = _database.GetCollection<Driver>("Driver");
        }

        public async Task<long> GetTripCountAsync()
        {
            var filter = Builders<Trip>.Filter.Ne(trip => trip.Status, "cancelled");
            return await _collectionTrip.CountDocumentsAsync(filter);
        }

        public async Task<long> GetBusCountAsync()
        {
            return await _collectionBus.CountDocumentsAsync(FilterDefinition<Bus>.Empty);
        }

        public async Task<long> GetDriverAsync()
        {
            return await _collectionDriver.CountDocumentsAsync(FilterDefinition<Driver>.Empty);
        }

        public async Task<List<MonthlyRevenue>> GetMonthlyRevenueAsync(int year = 2024)
        {
            var pipeline = new[]
            {
                new BsonDocument("$match",
                    new BsonDocument
                    {
                        { "$expr", new BsonDocument("$eq", new BsonArray { new BsonDocument("$year", "$Date"), year }) },
                        { "Status", "active" }
                    }
                ),
                new BsonDocument("$group", new BsonDocument
                {
                    { "_id", new BsonDocument
                        {
                            { "year", new BsonDocument("$year", "$Date") },
                            { "month", new BsonDocument("$month", "$Date") }
                        }
                    },
                    { "monthlyRevenue", new BsonDocument("$sum", "$Price") }
                }),
                new BsonDocument("$project", new BsonDocument
                {
                    { "_id", 0 },
                    { "month", "$_id.month" },
                    { "monthlyRevenue", 1 }
                }),
                new BsonDocument("$sort", new BsonDocument("month", 1))
            };

            var result = await _collectionTrip.Aggregate<MonthlyRevenue>(pipeline).ToListAsync();
            return result;
        }
        public async Task<List<RevenueByRegion>> GetTotalRevenueByRegionAsync(int year = 2024)
        {
            var pipeline = new[]
            {
            new BsonDocument("$match",
                new BsonDocument
                {
                    { "$expr", new BsonDocument("$eq", new BsonArray { new BsonDocument("$year", "$Date"), year }) },
                    { "Status", "active" }
                }
            ),
            new BsonDocument("$addFields", new BsonDocument("regionId", new BsonDocument("$toObjectId", "$Region"))),
            new BsonDocument("$lookup", new BsonDocument
            {
                { "from", "Region" },
                { "localField", "regionId" },
                { "foreignField", "_id" },
                { "as", "regionData" }
            }),
            new BsonDocument("$unwind", new BsonDocument
            {
                { "path", "$regionData" },
                { "preserveNullAndEmptyArrays", true }
            }),
            new BsonDocument("$group", new BsonDocument
            {
                { "_id", "$regionData.Name" },
                { "totalRevenue", new BsonDocument("$sum", "$Price") }
            }),
            new BsonDocument("$project", new BsonDocument
            {
                { "_id", 0 },
                { "region", "$_id" },
                { "totalRevenue", 1 }
            })
        };
            var result = await _collectionTrip.Aggregate<RevenueByRegion>(pipeline).ToListAsync();
            return result;
        }

        public async Task<List<RevenueBySchool>> GetTotalRevenueBySchoolAsync(int year = 2024)
        {
            var pipeline = new[]
            {
            new BsonDocument("$match",
                new BsonDocument
                {
                    { "$expr", new BsonDocument("$eq", new BsonArray { new BsonDocument("$year", "$Date"), year }) },
                    { "Status", "active" }
                }
            ),
            new BsonDocument("$addFields", new BsonDocument("schoolId", new BsonDocument("$toObjectId", "$School"))),
            new BsonDocument("$lookup", new BsonDocument
            {
                { "from", "School" },
                { "localField", "schoolId" },
                { "foreignField", "_id" },
                { "as", "schoolData" }
            }),
            new BsonDocument("$unwind", new BsonDocument
            {
                { "path", "$schoolData" },
                { "preserveNullAndEmptyArrays", true }
            }),
            new BsonDocument("$group", new BsonDocument
            {
                { "_id", "$schoolData.Name" },
                { "totalRevenue", new BsonDocument("$sum", "$Price") }
            }),
            new BsonDocument("$project", new BsonDocument
            {
                { "_id", 0 },
                { "school", "$_id" },
                { "totalRevenue", 1 }
            })
        };
            var result = await _collectionTrip.Aggregate<RevenueBySchool>(pipeline).ToListAsync();
            return result;
        }

        public async Task<string> GetTotalRevenueByYearAsync(int year)
        {
            var pipeline = new[]
            {
                new BsonDocument("$match",
                    new BsonDocument
                    {
                        { "$expr", new BsonDocument("$eq", new BsonArray { new BsonDocument("$year", "$Date"), year }) },
                        { "Status", "active" }
                    }
                ),
                new BsonDocument("$group", new BsonDocument
                {
                    { "_id", BsonNull.Value },
                    { "totalRevenue", new BsonDocument("$sum", "$Price") }
                }),
                new BsonDocument("$project", new BsonDocument
                {
                    { "_id", 0 },
                    { "totalRevenue", 1 }
                })
            };

            var result = await _collectionTrip.Aggregate<BsonDocument>(pipeline).FirstOrDefaultAsync();

            var resultNumber = result?["totalRevenue"].AsDouble; 
            return resultNumber?.ToString("C0", cultureInfo) ?? "0.00 ₫"; 
        }


        public class RevenueBySchool
        {
            public string school { get; set; }
            public double totalRevenue { get; set; }
        }

        public class MonthlyRevenue
        {
            public int month { get; set; }
            public double monthlyRevenue { get; set; }
        }

        public class RevenueByRegion
        {
            public string region { get; set; }
            public double totalRevenue { get; set; }
        }
    }
}
