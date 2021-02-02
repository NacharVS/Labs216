using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Labs216.Faskhutdinov
{
    class Student
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId id;
        [BsonElement("Islam")]
        public string name;
        [BsonElement("Ilnaz")]
        public string sername;
        [BsonIgnoreIfDefault]
        public int age;
        [BsonIgnoreIfNull]
        public string Email;
    }
    class Replace
    {
        private static async Task MongoReplaceByName (string searchName, int newAge)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("MAret");
            var collection = database.GetCollection<People>("Students");
            var update = Builders<Student>.Update.Set(a => a.age, newAge);
            await collection.UpdateOneAsync((a => a.name == searchName), update);

        }
        static async Task MongoreplaceByName(string searchName, Student newStudent)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("MAret");
            var collection = database.GetCollection<People>("Students");
            var update = Builders<Student>.Update.Set(a => , newStudent);
            await collection.UpdateOneAsync(std => std.name == searchName, update);
        }
    }
}
