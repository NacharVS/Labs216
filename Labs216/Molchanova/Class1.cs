using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Labs216.Molchanova
{
    class Class1
    {
        public class student
        {
            [BsonIgnoreIfDefault]
            public int age;
            [BsonIgnoreIfNull]
            public string mail;
            public ObjectId _id;
            [BsonElement("имя")]
            public string name;
            [BsonElement("фамилия")]
            [BsonIgnoreIfNull]
            public string surname;
        }
        static void Main(string[] args)
        {
            student student1 = new student { name = "Акакий", age = 8 };
            student student2 = new student { name = "Арсений", age = 16 };
            MongoIncert(student1).GetAwaiter().GetResult();
            MongoIncert(student2).GetAwaiter().GetResult();
        }

        private static async Task MongoIncert(student students)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var datebase = client.GetDatabase("University");
            var collection = datebase.GetCollection<student>("university students");
            await collection.InsertOneAsync(students);

        }

        static async Task SearchByName(string searchName, string searchSurname)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var datebase = client.GetDatabase("University");
            var collection = datebase.GetCollection<student>("university students");
            var students = await collection.Find(std => std.name == searchName & std.surname == searchSurname).ToListAsync();

            foreach (var item in students)
            {
                Console.WriteLine("имя студента - " + item.name);
                Console.WriteLine("фамилия студента - " + item.surname);
            }
        }
    }
}

