using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Labs216._2_семестр
{
    class MongoDB1
    {
        public static async Task MongoInsert(Chelovec chelovec)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("KruassanSloyKaMakaroshki");
            var collection = database.GetCollection<Chelovec>("Cheloveci");
            await collection.InsertOneAsync(chelovec);
        }
        //static async Task MongoConnect()
        //{
        //    string connectionString = "mongodb://localhost:27017";
        //    var client = new MongoClient(connectionString);
        //    var database = client.GetDatabase("KruassanSloyKaMakaroshki");
        //    var collection = database.GetCollection<BsonDocument>("Persons");
        //    var person = new BsonDocument();
        //}
    }
    public class Chelovec
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        [BsonElement("Imya")]
        public string name;
        [BsonElement("Familiya")]
        [BsonIgnoreIfNull]
        public string surname;
        [BsonIgnoreIfDefault]
        public int age;
        [BsonIgnoreIfDefault]
        public string Email;

        public Chelovec(string name)
        {
            this.name = name;
        }
        public Chelovec(string name,string surname, int agee)
        {
            this.name = name;
            this.surname = surname;
            age = agee;

        }
        public static async Task SearchByName(string searchName, string searchSurname)
        {
            string connectionString = "mongodb://localhost"; //адрес сервера
            var client = new MongoClient(connectionString);
            var datebase = client.GetDatabase("KruassanSloyKaMakaroshki");
            var collection = datebase.GetCollection<Chelovec>("Cheloveci");
            var students = await collection.Find(std => std.name == searchName & std.surname == searchSurname).ToListAsync();

            foreach (var item in students)
            {
                Console.WriteLine("name - " + item.name);
                Console.WriteLine("surname - " + item.surname);
            }
            //поиск повторений
        }
        public static async Task MongoReplaceByName (string searchName, Chelovec newChelovec)
        {
            string connectionString = "mongodb://localhost"; //адрес сервера
            var client = new MongoClient(connectionString);
            var datebase = client.GetDatabase("KruassanSloyKaMakaroshki");
            var collection = datebase.GetCollection<Chelovec>("Cheloveci");
            await collection.ReplaceOneAsync(x => x.name == searchName, newChelovec);
            //метод обновление данных, замена 
        }
        public static async Task MongoReplaceByName(string searchName)
        {
            string connectionString = "mongodb://localhost"; //адрес сервера
            var client = new MongoClient(connectionString);
            var datebase = client.GetDatabase("KruassanSloyKaMakaroshki");
            var collection = datebase.GetCollection<Chelovec>("Cheloveci");
            await collection.DeleteOneAsync(x => x.name == searchName);
            //метод удаление
            // ИЛИ -|| И - &
        }
    }
}
