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
    class Replace
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
class Program
{
    static async Task MongoReplaceByName(string searchName, Student newStudent)
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("216TeamDB");
        var collection = database.GetCollection<Student>("Students");
        await collection.ReplaceOneAsync(x => x.name == searchName, newStudent);
    }
    static async Task SearchByName(string searchName, string searchSurname)
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("216TeamDB");
        var collection = database.GetCollection<Student>("Students");
        var students = await collection.Find(std => std.name == searchName & std.surname == searchSurname).ToListAsync();
        foreach (var item in students)
        {
            Console.WriteLine(item.name);
        }
    }
    static async Task MongoInsert(Student student)
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("216TeamDB");
        var collection = database.GetCollection<Student>("Students");
        await collection.InsertOneAsync(student);
    }
    static async Task MongoConnect()
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("216TeamDB");
        var collection = database.GetCollection<Student>("Students");
        var student = new BsonDocument();
        var students = await collection.Find(student).ToListAsync();
        foreach (var item in students)
        {
            Console.WriteLine(item.name);
            Console.WriteLine(item._id);
            Console.WriteLine(item.age);
            static void Main()
            {
                MongoConnect().GetAwaiter().GetResult();
            }
        }
    }
}
