using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Labs216.Topunova.Mongo_DB
{
    class MongoDB
    {
        public static async Task MongoInsert(Deti deti)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("DetskiySad");
            var collection = database.GetCollection<Deti>("Detis");
            await collection.InsertOneAsync(deti);
        }
    }
}
