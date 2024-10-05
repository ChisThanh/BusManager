using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using DotNetEnv;
using System.Collections;

namespace DTO
{
    public class Database
    {
        private static IMongoDatabase _database;
        private static readonly object _lock = new object();
        private static MongoClient _client;
        private static Database _instance;
        private Database()
        {
            Connect(); 
        }

        public static Database Instance
        {
            get
            {
                if (_instance == null)
                    lock (_lock)
                        if (_instance == null)
                            _instance = new Database();
                return _instance;
            }
        }

        private void Connect()
        {
            Env.TraversePath().Load();
            string dbHost = Env.GetString("DB_HOST");
            string dbPort = Env.GetString("DB_PORT");
            string dbUser = Env.GetString("DB_USER");
            string dbPass = Env.GetString("DB_PASS");
            string dbName = Env.GetString("DB_NAME");
            string connectionString = $"mongodb://{dbUser}:{dbPass}@{dbHost}:{dbPort}/";

            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(dbName);
        }

        public IMongoDatabase GetDatabase()
        {
            return _database;
        }
    }

}
