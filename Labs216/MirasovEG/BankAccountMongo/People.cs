using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.MirasovEG
{
    class People
    {
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public int Age { get; set; }

        public People(string name, string surname, int age, int phoneNumber)
        {
            Name = name;
            Surname = surname;
            Age = age;
            PhoneNumber = phoneNumber;
        }

    }
}
