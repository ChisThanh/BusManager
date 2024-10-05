using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Schemas
{
    public class User
    {
        public ObjectId Id { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("password")]
        public string Password { get; set; }
    }
}
