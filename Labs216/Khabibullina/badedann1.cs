using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;


namespace Labs216.Khabibullina
{
    class Student
    {
        [BsonId]
        public int _id;
        [BsonElement("Name")]
        public string name;
        [BsonIgnoreIfDefault]
        public int age;

    }
    class Program
    {
        static void Main()
        {
            Student student1 = new Student { _id = 666, name = "Satan", age = 999999 };
            Student student2 = new Student { _id = 5478, name = "Elizabeth Bathory The Best Woman in the World", age = 46 };
            MongoIncert(student1).GetAwaiter().GetResult();
            MongoIncert(student2).GetAwaiter().GetResult();
        }

        static async Task MongoIncert(Student student)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("216TeamDB");
            var collection = database.GetCollection<Student>("Students");
            await collection.InsertManyAsync(student);
        }
        static async Task MongoIncert()
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
            }
        }
    }
}

