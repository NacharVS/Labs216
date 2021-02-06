using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Labs216.Tarskih;

namespace Labs216.Tarskih
{
    class MongoDB
    {
        public static async Task MongoInsert(User user)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("CoffeeTime");
            var collection = database.GetCollection<User>("Users");
            await collection.InsertOneAsync(user);
        }
    }
}
