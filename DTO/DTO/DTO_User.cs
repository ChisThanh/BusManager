using DTO.Schemas;
using MongoDB.Driver;

namespace DTO
{
    public class DTO_User : DTO_Base<User>
    {
        public DTO_User() : base("Users")
        {
        }
    }
}
