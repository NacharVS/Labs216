using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace Labs216.Gabdulkhaev
{
    class NotStudent
    {
        [BsonId]
        public ObjectId _id;
        [BsonElement("Imya")]
        public string name;
        [BsonElement("Familiya")]
        public string surname;
        [BsonIgnoreIfDefault]
        public int age;
    }
    class Program
    {
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
                Console.WriteLine(item.age);
            }
        }
        //static void Main()
        //{
        // NotStudent student = new NotStudent { name = "Ivan", surname = "Sidorov", age = 50 };
        // SearchByName("Ivan", "Sidorov").GetAwaiter().GetResult();
        // MongoInsert(student).GetAwaiter().GetResult();
        //}
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
}
