using DTO.Schemas;
using MongoDB.Driver;

namespace DTO
{
    public class DTO_Student : DTO_Base<Student>
    {
        public DTO_Student() : base("Student")
        {
        }
    }
}
