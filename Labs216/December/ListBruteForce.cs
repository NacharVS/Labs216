using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.December
{
    class ListBruteForce
    {
        public static void BruteForce()
        {
            List<Account> accounts = new List<Account>();
            accounts.Add(new Account(1, "Ruslan", new DateTime(2000, 5, 25)));
            accounts.Add(new Account(2, "Azalia", new DateTime(2003, 6, 9)));
            accounts.Add(new Account(3, "Zulfia", new DateTime(2003, 3, 24)));
            accounts.Add(new Account(4, "Zuxra", new DateTime(2004, 2, 1)));
            accounts.Add(new Account(5, "Julya", new DateTime(2002, 9, 17)));
            foreach (var item in accounts)
            {
                Console.WriteLine($" {item.Id} {item.Name} {item.Age}");
            }
            foreach (var item in accounts)
            {
                item.EventID += item.Reaction;
            }
            accounts[1].EditingID(22);
        }
    }
    public delegate void Rabbit(int ID);
    class Account
    {
        private int _id;
        public string Name;
        public DateTime BirthDay;
        public int Age;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public Account(string name)
        {
            Name = name;
        }

        public Account(int id, string name, DateTime data)
        {
            _id = id;
            Name = name;
            BirthDay = data;
            Age = DateTime.Now.Year - BirthDay.Year;
        }
        public event Rabbit EventID;
        public void Reaction(int newID)
        {
            Console.WriteLine($" ID of {Name} is chaned to {newID}");
        }
        public void EditingID(int newID)
        {
            Id = newID;
        }
    }
}
