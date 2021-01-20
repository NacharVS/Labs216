using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Labs216.MirasovEG.BankAccountMongo
{
    class MongoDB1
    {
        public static async Task SaveDocs(People person)
        {
            string connection = "mongodb://localhost";
            var client = new MongoClient(connection);
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<People>("people");

            await collection.InsertOneAsync(person);

            var filter = new BsonDocument();
            var people = await collection.Find(filter).ToListAsync();

            foreach (People item in people)
            {
                Console.WriteLine("{0} - {1} ({2})", item.Name, item.Surname, item.PhoneNumber, item.Age);
            }

        }
    }
}
