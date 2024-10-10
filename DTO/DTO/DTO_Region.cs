using DTO.Schemas;
using MongoDB.Driver;

namespace DTO
{
    public class DTO_Region : DTO_Base<Region>
    {
        public DTO_Region() : base("Region")
        {
        }
    }
}
