using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

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
    static void PoiskPoImeni(string searchName)
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var database=client.GetDatabase()
    }
    {

    }
       // все, что работает с базами данных
    }
}
