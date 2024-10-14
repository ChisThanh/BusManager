using DTO.Schemas;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Student 
    {
        private IMongoCollection<Student> _students;

        public DTO_Student()
        {
            var database = Database.Instance.GetDatabase();
            _students = database.GetCollection<Student>("Student");
        }
        public List<Student> GetAllStudents() => _students.Find(student => true).ToList();
        public Student GetStudentById(ObjectId id)
        {
            return _students.Find(student => student.Id == id).FirstOrDefault();
        }

        public async Task<List<Student>> GetStudentsByRegionAsync(string regionName)
        {
            // Tạo filter để tìm kiếm sinh viên có địa chỉ chứa tên quận
            var filter = Builders<Student>.Filter.Regex(s => s.Address, new BsonRegularExpression(regionName, "i")); // 'i' cho không phân biệt chữ hoa chữ thường
            var students = await _students.Find(filter).ToListAsync();
            return students;
        }

        public void UpdateStudent(Student student)
        {
            var filter = Builders<Student>.Filter.Eq(s => s.Id, student.Id);
            _students.ReplaceOne(filter, student);
        }

        public void DeleteStudent(Student student)
        {
            var filter = Builders<Student>.Filter.Eq(s => s.Id, student.Id);
            _students.DeleteOne(filter);
        }

        public void AddStudent(Student student)
        {
            _students.InsertOne(student);
        }
    }
}
