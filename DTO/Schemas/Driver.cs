using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Schemas
{
    public class License
    {
        public string ID { get; set; }
        public List<string> Class { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
    public class Driver
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DoB { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public License License { get; set; }

    }
}
