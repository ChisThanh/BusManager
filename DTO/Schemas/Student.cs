using MongoDB.Bson;
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
        [BsonId]
        public ObjectId Id { get; set; }
        // Thuộc tính tên sinh viên
        public string Name { get; set; }

        // Thuộc tính giới tính (Nam/Nữ)
        public string Gender { get; set; }

        // Thuộc tính ngày sinh (Date of Birth)
        public DateTime DoB { get; set; }

        // Thuộc tính số điện thoại
        public string Phone { get; set; }

        // Thuộc tính địa chỉ
        public string Address { get; set; }
        public ObjectId School { get; set; }
        public List<string> Schedules { get; set; }
    }
}
