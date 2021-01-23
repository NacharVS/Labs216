﻿using System;
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
        
        public ObjectId _id;
        [BsonElement("Imya")]
        public string name;
        [BsonElement("Familiya")]
        public string surname;
        [BsonIgnore]
        public int age;
        [BsonIgnoreIfDefault]
        public string Email;

        public Chelovec(string name)
        {
            this.name = name;
        }
        static async Task SearchByName(string searchName, string searchSurname)
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
        }
    }
}
