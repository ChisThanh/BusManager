using DTO.Schemas;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Student : DTO_Base<Student>
    {
        private IMongoCollection<Student> _students;
        public DTO_Student() : base("Student")
        {
            var database = Database.Instance.GetDatabase();
            _students = database.GetCollection<Student>("Student");
        }
        public List<Student> GetAllStudents() => _students.Find(student => true).ToList();
        public Student GetStudentById(ObjectId id)
        {
            return _students.Find(student => student.Id == id).FirstOrDefault();
        }
    
        public void AddStudent(Student student)
        {
            _students.InsertOne(student);
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
    }
}
