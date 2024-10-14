using DTO.Schemas;
using MongoDB.Driver;

namespace DTO
{
    public class DTO_Driver : DTO_Base<Driver>
    {
        public DTO_Driver() : base("Driver")
        {
        }
    }
}
