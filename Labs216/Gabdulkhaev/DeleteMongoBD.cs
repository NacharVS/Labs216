using Labs216.Gabdulkhaev;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Labs216.Gabdulkhaev
{
    class DeleteMongoBD
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        [BsonElement("Imya")]
        public string name;
        [BsonElement("Familiya")]
        public string surname;
        [BsonIgnoreIfDefault]
        public int age;
        [BsonIgnoreIfDefault]
        public DateTime dateTime;
        [BsonIgnoreIfNull]
        public string Email;
    }
}

class Proga
{
    static async Task MongoUpdate(string searchName, int age)
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("CosmicCaramel");
        var collection = database.GetCollection<Student>("PS");
        await collection.DeleteOneAsync(cheplovek => cheplovek.name == searchName && cheplovek.age == age);
    }
    static async Task MongoConnect()
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("216TeamDB");
        var collection = database.GetCollection<Student>("Students");
        var student = new BsonDocument();
        var students = await collection.Find(student).ToListAsync();
    }
}