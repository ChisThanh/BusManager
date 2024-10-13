using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Schemas
{
	public class Trip
    {
        public ObjectId Id { get; set; }
        public DateTime Date { get; set; }
        public string Bus { get; set; }
        public string Driver { get; set; }
        public string School { get; set; }
        public string Region { get; set; }
        public List<string> Students { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }

		[BsonIgnore]
		public Bus BusObj { get; set; }
		[BsonIgnore]
		public Driver DriverObj { get; set; }
		[BsonIgnore]
		public School SchoolObj { get; set; }
		[BsonIgnore]
		public Region RegionObj { get; set; }
		[BsonIgnore]
		public List<Student> StudentsObj { get; set; }
	}
}
