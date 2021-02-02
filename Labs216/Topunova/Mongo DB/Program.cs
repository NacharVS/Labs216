using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Labs216.Topunova.Mongo_DB
{
    class Program
    {
        static void Main(string[] args)
        {
            Deti deti = new Deti("Petya");
        }
    }
}
