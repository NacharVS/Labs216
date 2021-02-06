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
    class UpdateNeReplac
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

class Prog
{
    static async Task MongoUpdate(string searchName, int newAge)
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("CosmicCaramel");
        var collection = database.GetCollection<NotStudent>("PS");
        var update = Builders<NotStudent>.Update.Set(a => a.age, newAge);
        await collection.UpdateOneAsync(x => x.name == searchName, update);
    }
    static async Task SearchByName(string searchName, string searchSurname)
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("216TeamDB");
        var collection = database.GetCollection<NotStudent>("Students");
        var students = await collection.Find(std => std.name == searchName & std.surname == searchSurname).ToListAsync();
        foreach (var item in students)
        {
            Console.WriteLine(item.name);
        }
    }
    static async Task MongoInsert(NotStudent student)
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("216TeamDB");
        var collection = database.GetCollection<NotStudent>("Students");
        await collection.InsertOneAsync(student);
    }
    static async Task MongoConnect()
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("216TeamDB");
        var collection = database.GetCollection<NotStudent>("Students");
        var student = new BsonDocument();
        var students = await collection.Find(student).ToListAsync();
        foreach (var item in students)
        {
            Console.WriteLine(item.name);
            Console.WriteLine(item._id);
            Console.WriteLine(item.age);
        }
    }
}
    //}
    //static void Main()
    //            {
    //                MongoConnect().GetAwaiter().GetResult();
    //            }
    //        }
