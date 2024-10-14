using DTO.Schemas;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Region
    {
        private IMongoCollection<Region> _regionCollection;

        public DTO_Region()
        {
            var database = Database.Instance.GetDatabase();
            _regionCollection = database.GetCollection<Region>("Region");
        }

        // Phương thức lấy danh sách tên quận từ MongoDB
        public async Task<List<Region>> GetRegionsAsync()
        {
            // Lấy danh sách các đối tượng Region từ MongoDB
            var regions = await _regionCollection
                .Find(_ => true)
                .ToListAsync();

            return regions;
        }

        public async Task InsertRegionAsync(Region region)
        {
            // Thêm đối tượng Region vào MongoDB
            await _regionCollection.InsertOneAsync(region);
        }

        public async Task UpdateRegionAsync(Region region)
        {
            // Cập nhật đối tượng Region trong MongoDB
            var filter = Builders<Region>.Filter.Eq(r => r.Id, region.Id);
            await _regionCollection.ReplaceOneAsync(filter, region);
        }
        public async Task DeleteRegionAsync(ObjectId regionId)
        {
            // Xóa đối tượng Region khỏi MongoDB
            var filter = Builders<Region>.Filter.Eq(r => r.Id, regionId);
            await _regionCollection.DeleteOneAsync(filter);
        }

    }
}
