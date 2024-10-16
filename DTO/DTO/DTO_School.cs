using DTO.Schemas;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_School : DTO_Base<School>
    {
        private readonly IMongoCollection<School> _schools;

        public DTO_School() : base("School")
        {
            var database = Database.Instance.GetDatabase();
            _schools = database.GetCollection<School>("School");
        }
        public void AddSchool(School school)
        {
            _schools.InsertOne(school);
        }

        public List<School> GetAllSchools()
        {
            return _schools.Find(_ => true).ToList(); 
        }
        public School GetSchoolById(ObjectId id)
        {
            return _schools.Find(school => school.Id == id).FirstOrDefault();
        }

        public void UpdateSchool(School school)
        {
            var filter = Builders<School>.Filter.Eq(s => s.Id, school.Id);
            _schools.ReplaceOne(filter, school);
        }

        public void DeleteSchool(School schoolId)
        {
            var filter = Builders<School>.Filter.Eq(s => s.Id, schoolId.Id);
            _schools.DeleteOne(filter);
        }

        public async Task<IEnumerable<object>> GetAllStudentsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
