using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Labs216.Gabdulkhaev
{
    class BankBD
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
    // все, что работает с базами данных
    class Student
    {
        static void Main()
        {
            Student student1 = new Student { name = "Igor", age = 15 };
            Student student2 = new Student { name = "Maksim" };
            MongoInsert(student1).GetAwaiter().GetResult();
        }
        static async Task MongoInsert(Student student)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("216TeamDB");
            var collection = database.GetCollection<Student>("Students");
            await collection.InsertOneAsync(student);
        }
}
    }
