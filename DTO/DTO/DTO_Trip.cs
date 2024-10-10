using DTO.Schemas;
using MongoDB.Driver;

namespace DTO
{
    public class DTO_Trip : DTO_Base<Trip>
    {
        public DTO_Trip() : base("Trip")
        {
        }
    }
}
