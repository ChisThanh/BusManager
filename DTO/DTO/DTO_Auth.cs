using DTO.Schemas;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Auth
    {
        private readonly IMongoCollection<User> _userCollection;

        public DTO_Auth()
        {
            var database = Database.Instance.GetDatabase();
            _userCollection = database.GetCollection<User>("Users");
        }

        public async Task<bool> RegisterAsync(string email, string name, string password)
        {
            var existingUser = await _userCollection.Find(u => u.Email == email).FirstOrDefaultAsync();
            if (existingUser != null)
                throw new System.Exception("Người dùng đã tồn tại");

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            var newUser = new User
            {
                Email = email,
                Name = name,
                Password = hashedPassword
            };

            await _userCollection.InsertOneAsync(newUser);
            return true;
        }

        public async Task<bool> LoginAsync(string email, string password)
        {
            var user = await _userCollection.Find(u => u.Email == email).FirstOrDefaultAsync();
            if (user == null)
                throw new System.Exception("Người dùng không tồn tại");

            if (!BCrypt.Net.BCrypt.Verify(password, user.Password))
                throw new System.Exception("Mật khẩu không chính xác");

            return true;
        }
    }
}
