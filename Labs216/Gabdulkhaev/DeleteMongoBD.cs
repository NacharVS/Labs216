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
    static async Task MongoDelete(string searchName, int age)
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("216TeamDB");
        var collection = database.GetCollection<NotStudent>("Students");
        await collection.DeleteOneAsync(cheplovek => cheplovek.name == searchName && cheplovek.age == age);
    }
    static async Task MongoConnect()
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("216TeamDB");
        var collection = database.GetCollection<NotStudent>("Students");
        var student = new BsonDocument();
        var students = await collection.Find(student).ToListAsync();
    }
    static async Task MongoInsert(NotStudent student)
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("216TeamDB");
        var collection = database.GetCollection<NotStudent>("Students");
        await collection.InsertOneAsync(student);
    }
    static void Main()
    {
        MongoDelete("Ivan", 50).GetAwaiter().GetResult();
    }
}