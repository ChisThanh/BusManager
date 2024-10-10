using DTO.Schemas;
using MongoDB.Driver;

namespace DTO
{
    public class DTO_School : DTO_Base<School>
    {
        public DTO_School() : base("School")
        {
        }
    }
}
