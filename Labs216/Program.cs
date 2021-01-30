﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Labs216
{
    class Program
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
