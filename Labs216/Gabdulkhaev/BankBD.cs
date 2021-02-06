//using MongoDB.Bson;
//using MongoDB.Bson.Serialization.Attributes;
//using MongoDB.Driver;
//using Labs216.Gabdulkhaev;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace Labs216.Gabdulkhaev
//{
//    class BankBD
//    {
//        [BsonId]
//        public ObjectId _id;
//        [BsonElement("Imya")]
//        public string name;
//        [BsonElement("Familiya")]
//        public string surname;
//        [BsonIgnoreIfDefault]
//        public int age;
//    }
//    // все, что работает с базами данных
//    class NotStudent
//    {
//        static void Main()
//        {
//            bank2 prikol = new bank2();
//            NotStudent student1 = new NotStudent { name = "Igor", surname="Familiya", _id=prikol._id, age = 15, };
//            NotStudent student2 = new NotStudent { name = "Maksim" };
//            MongoInsert(student1).GetAwaiter().GetResult();
//        }
//        static async Task MongoInsert(NotStudent student)
//        {
//            string connectionString = "mongodb://localhost";
//            var client = new MongoClient(connectionString);
//            var database = client.GetDatabase("216TeamDB");
//            var collection = database.GetCollection<NotStudent>("Students");
//            await collection.InsertOneAsync(student);
//        }
//}
//    }
