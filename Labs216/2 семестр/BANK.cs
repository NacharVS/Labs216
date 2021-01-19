using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Labs216._2_семестр
{
    class BANK
    {
        [BsonId]
        public ObjectId _id;
        [BsonElement("Imya")]
        public string name;
        [BsonIgnore]
        public int age;
    
        public void Connection()
        {
            string connectionString = "mongodb://localhost:27017"; //сервер
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase("BankDB");
        }
        
    }
}
