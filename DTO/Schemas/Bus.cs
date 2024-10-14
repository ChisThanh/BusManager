using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Schemas
{
    public class Bus
    {
        
        public ObjectId Id { get; set; }
        public string LicensePlate { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Capacity { get; set; }
    }
}
