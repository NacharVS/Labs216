using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Faskhutdinov
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
    [BsonIgnoreIfDefault]
    public DataTime dataTime;
    [BsonIgnoreIfNull]
    public string Email;
    class Replace
    {
        public static void Main(string[] args)
        {
            string connection = "mongodb://localhost";
            var client = new MongoClient(connection);
            var database = client.GetDatabase("MAret");
            var collection = database.GetCollection<People>("Students");
            var std = collection.Find(std => std.Surname == "Faskhutdinov").ToListAsync().GetAwaiter().GetResult();
            People imf = new People("Islam", "Faskhutdinov", 17, 3940293);
            collection.InsertOneAsync(imf).GetAwaiter().GetResult();

            foreach (var item in std)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
