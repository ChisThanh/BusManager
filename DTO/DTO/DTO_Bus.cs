using DTO.Schemas;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DTO
{
    public class DTO_Bus : DTO_Base<Bus>
    {
        public DTO_Bus() : base("Bus")
        {
        }
    }
}
