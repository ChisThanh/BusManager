using DAL.Models;
using MongoDB.Driver;

namespace DAL
{
    public class DALUser : DALBase<User>
    {
        public DALUser() : base("Users")
        {
        }

    }
}
