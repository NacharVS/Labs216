using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Labs216._2_семестр
{
    class MongoDB
    {
        class Student
        {
            [BsonId]
            public int _id;
            [BsonElement("Imya")]
            public string name;
            [BsonElement("Familiya")]
            public string surname;
            [BsonIgnore]
            public int age;
        }
       
        static async Task SearchByName(string searchName, string searchSurname)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var datebase = client.GetDatabase("216TeamDB");
            var collection = datebase.GetCollection<Student>("Students");
            var students = await collection.Find(std => std.name == searchName & std.surname == searchSurname);

            foreach (var item in students)
            {
                Console.WriteLine("name - " + item.name);
                Console.WriteLine("surname - " + item.surname);
            }
        }
        

        
    }
}
