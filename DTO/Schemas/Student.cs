﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Schemas
{
    public class Student
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DoB { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public ObjectId School { get; set; }
        public List<string> Schedules { get; set; }
	}
}
