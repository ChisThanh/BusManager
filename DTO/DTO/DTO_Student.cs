using DTO.Schemas;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class DTO_Student
    {
        private IMongoCollection<Student> _studentCollection;

        public DTO_Student()
        {
            var database = Database.Instance.GetDatabase();
            _studentCollection = database.GetCollection<Student>("Student");
        }

        public async Task<List<Student>> GetStudentsByRegionAsync(string regionName)
        {
            // Tạo filter để tìm kiếm sinh viên có địa chỉ chứa tên quận
            var filter = Builders<Student>.Filter.Regex(s => s.Address, new BsonRegularExpression(regionName, "i")); // 'i' cho không phân biệt chữ hoa chữ thường
            var students = await _studentCollection.Find(filter).ToListAsync();
            return students;
        }



    }
}

