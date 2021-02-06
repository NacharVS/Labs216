using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Threading;
using System.Threading.Tasks;
using Labs216.Tarskih;

namespace Labs216.Tarskih
{
    public class User
    {

        public ObjectId _id;
        [BsonElement("Name")]
        public string name;
        [BsonElement("Surname")]
        public string surname;
        [BsonIgnore]
        public int age;
        [BsonIgnoreIfDefault]
        public string Email;

        public User(string name)
        {
            this.name = name;
        }
        static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("CoffeeTime");
            var collection = database.GetCollection<User>("Users");
            var user = new BsonDocument();
            var users = await collection.Find(user).ToListAsync();
            foreach (var item in users)
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
        static async Task MongoUpdate(string searchName, int newAge)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("CoffeeTime");
            var collection = database.GetCollection<User>("Users");
            var update = Users<User>.Update.Set(a => a.age, newAge);
            await collection.UpdateOneAsync(x => x.name == searchName, update);
        }
        static async Task SearchByName(string searchName, string searchSurname)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var datebase = client.GetDatabase("CoffeeTime");
            var collection = datebase.GetCollection<User>("Users");
            var students = await collection.Find(std => std.name == searchName & std.surname == searchSurname).ToListAsync();

            foreach (var item in students)
            {
                Console.WriteLine("name - " + item.name);
                Console.WriteLine("surname - " + item.surname);
            }
        }
        static async Task MongoReplaceByName(string searchName, User newUser)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var datebase = client.GetDatabase("CoffeeTime");
            var collection = datebase.GetCollection<User>("Users");
            await collection.ReplaceOneAsync(x => x.name == searchName, newUser);
        }
        static async Task MongoDeleteByName(string searchName)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var datebase = client.GetDatabase("CoffeeTime");
            var collection = datebase.GetCollection<User>("Users");
            await collection.DeleteManyAsync(std => std.name == searchName);
        }
    }
}
