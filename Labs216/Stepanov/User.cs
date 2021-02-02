using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Labs216.Stepanov
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
    }
}
