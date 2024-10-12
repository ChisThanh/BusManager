using DTO.Schemas;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DTO.DTO
{
    public class DTO_Statistical
    {

        protected readonly IMongoCollection<Trip> _collectionTrip;
        protected readonly IMongoCollection<Bus> _collectionBus;
        protected readonly IMongoCollection<Driver> _collectionDriver;

        public IMongoDatabase _database = Database.Instance.GetDatabase();
        CultureInfo cultureInfo = new CultureInfo("vi-VN");
        public DTO_Statistical()
        {
            _collectionTrip = _database.GetCollection<Trip>("Trip");
            _collectionBus = _database.GetCollection<Bus>("Bus");
            _collectionDriver = _database.GetCollection<Driver>("Driver");
        }

        public async Task<long> GetBusCountAsync()
        {
            return await _collectionBus.CountDocumentsAsync(FilterDefinition<Bus>.Empty);
        }

        public async Task<long> GetDriverAsync()
        {
            return await _collectionDriver.CountDocumentsAsync(FilterDefinition<Driver>.Empty);
        }

        public async Task<List<MonthlyRevenue>> GetMonthlyRevenueAsync(int year = 2024)
        {
            var pipeline = new[]
            {
                new BsonDocument("$match", new BsonDocument("$expr", new BsonDocument("$eq", new BsonArray { new BsonDocument("$year", "$Trip.Date"), year }))),
                new BsonDocument("$group", new BsonDocument
                {
                    { "_id", new BsonDocument
                        {
                            { "year", new BsonDocument("$year", "$Trip.Date") },
                            { "month", new BsonDocument("$month", "$Trip.Date") }
                        }
                    },
                    { "monthlyRevenue", new BsonDocument("$sum", "$Trip.Price") }
                }),
                new BsonDocument("$project", new BsonDocument
                {
                    { "_id", 0 },
                    { "month", "$_id.month" },
                    { "monthlyRevenue", 1 }
                }),
                new BsonDocument("$sort", new BsonDocument("month", 1))
            };

            var result = await _collectionTrip.Aggregate<MonthlyRevenue>(pipeline).ToListAsync();
            return result;
        }
        public async Task<List<RevenueByRegion>> GetTotalRevenueByRegionAsync(int year = 2024)
        {
            var pipeline = new[]
            {
            new BsonDocument("$match", new BsonDocument("$expr", new BsonDocument("$eq", new BsonArray { new BsonDocument("$year", "$Trip.Date"), year }))),
            new BsonDocument("$addFields", new BsonDocument("regionId", new BsonDocument("$toObjectId", "$Trip.Region"))),
            new BsonDocument("$lookup", new BsonDocument
            {
                { "from", "Region" },
                { "localField", "regionId" },
                { "foreignField", "_id" },
                { "as", "regionData" }
            }),
            new BsonDocument("$unwind", new BsonDocument
            {
                { "path", "$regionData" },
                { "preserveNullAndEmptyArrays", true }
            }),
            new BsonDocument("$group", new BsonDocument
            {
                { "_id", "$regionData.Region.Name" },
                { "totalRevenue", new BsonDocument("$sum", "$Trip.Price") }
            }),
            new BsonDocument("$project", new BsonDocument
            {
                { "_id", 0 },
                { "region", "$_id" },
                { "totalRevenue", 1 }
            })
        };

            var result = await _collectionTrip.Aggregate<RevenueByRegion>(pipeline).ToListAsync();
            return result;
        }

        public async Task<string> GetTotalRevenueByYearAsync(int year)
        {
            var pipeline = new[]
            {
                new BsonDocument("$match", new BsonDocument("$expr", new BsonDocument("$eq", new BsonArray { new BsonDocument("$year", "$Trip.Date"), year }))),
                new BsonDocument("$group", new BsonDocument
                {
                    { "_id", BsonNull.Value },
                    { "totalRevenue", new BsonDocument("$sum", "$Trip.Price") }
                }),
                new BsonDocument("$project", new BsonDocument
                {
                    { "_id", 0 },
                    { "totalRevenue", 1 }
                })
            };

            var result = await _collectionTrip.Aggregate<BsonDocument>(pipeline).FirstOrDefaultAsync();


            var resultNumber = result?["totalRevenue"].AsInt32; 
            return resultNumber?.ToString("C0", cultureInfo) ?? "0.00 ₫"; 
        }



        public class MonthlyRevenue
        {
            public int month { get; set; }
            public double monthlyRevenue { get; set; }
        }

        public class RevenueByRegion
        {
            public string region { get; set; }
            public double totalRevenue { get; set; }
        }
    }
    


}
