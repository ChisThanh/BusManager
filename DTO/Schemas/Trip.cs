using MongoDB.Bson;
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

        public Bus BusObj { get; set; }
        public Driver DriverObj { get; set; }
        public School SchoolObj { get; set; }
        public Region RegionObj { get; set; }
        public List<Student> StudentsObj { get; set}
    }
}
