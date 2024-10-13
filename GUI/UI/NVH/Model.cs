using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.UI.NVH
{
    public class School
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }
        public DateTime DoB { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string SchoolId { get; set; }  // Liên kết với School
        public string Gender { get; internal set; }
        public string Phone { get; internal set; }
        public string Address { get; internal set; }

       
    }
}
