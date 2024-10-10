using DTO.Schemas;
using MongoDB.Driver;

namespace DTO
{
    public class DTO_Bus : DTO_Base<Bus>
    {
        public DTO_Bus() : base("Bus")
        {
        }
    }
}
