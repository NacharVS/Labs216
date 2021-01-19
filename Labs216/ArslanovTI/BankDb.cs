using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI
{
    class BankDb
    {
        class Client
        {
            [BsonId]
            public  ObjectId _id;
            [BsonElement("Name")]
            public string name;
            [BsonElement("Surname")]
            public string surname;
            [BsonElement("Age")]
            public string age;

        }
        
            
        
        public void Connection()
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase("DBBank");
        }
        public void Registration()
        {
            
        }

    }
}
