using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Base<T>
    {
        protected readonly IMongoCollection<T> _collection;

        protected DTO_Base(string collectionName)
        {
            var database = Database.Instance.GetDatabase();
            _collection = database.GetCollection<T>(collectionName);
        }

        public List<T> GetAll()
        {
            return _collection.Find(new BsonDocument()).ToList();
        }

        public T Find(string idString)
        {
            if (!ObjectId.TryParse(idString, out ObjectId id))
                return default;

            var filter = Builders<T>.Filter.Eq("_id", id);
            return _collection.Find(filter).FirstOrDefault();
        }

        public T Find(string key, object value)
        {
            try
            {
                var filter = Builders<T>.Filter.Eq(key, value);
                return _collection.Find(filter).FirstOrDefault();
            }
            catch (Exception)
            {
                return default;
            }
        }
        public bool Insert(T document)
        {
            try
            {
                _collection.InsertOne(document);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(string idString, T document)
        {
            try
            {
                if (!ObjectId.TryParse(idString, out ObjectId id))
                    return false;

                var documentAsBson = document.ToBsonDocument();
                if (documentAsBson.Contains("_id"))
                    documentAsBson["_id"] = id;
                else
                    documentAsBson.Add("_id", id);

                var updatedDocument = BsonSerializer.Deserialize<T>(documentAsBson);

                var filter = Builders<T>.Filter.Eq("_id", id);
                _collection.ReplaceOne(filter, updatedDocument);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(T document)
        {
            try
            {
                var idProperty = typeof(T).GetProperty("_id");
                if (idProperty == null)
                    return false;

                var idValue = idProperty.GetValue(document);
                if (idValue == null || !(idValue is ObjectId id))
                    return false;

                var filter = Builders<T>.Filter.Eq("_id", id);

                _collection.ReplaceOne(filter, document);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public bool Delete(string idString)
        {
            try
            {
                if (!ObjectId.TryParse(idString, out ObjectId id))
                {
                    return false;
                }
                var filter = Builders<T>.Filter.Eq("_id", id);
                _collection.DeleteOne(filter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(string key, object value)
        {
            try
            {
                var filter = Builders<T>.Filter.Eq(key, value);
                _collection.DeleteOne(filter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
