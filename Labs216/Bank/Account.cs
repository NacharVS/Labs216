using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bank
{
    class Account
    {
        public delegate void OnAccount(string message);
        public event OnAccount Check = (string message) => Console.WriteLine(message);
        public Account(string name, string surname, int year, int month)
        {
            Name = name;
            Surname = surname;
            Year = year;
            Month = month;
        }

        private string _name;
        private string _surname;
        private string _id;
        private static int _count;
        private double _account;
        private int Year { get; set; }
        private int Month { get; set; }

        public string Name
        {
            get => _name;
            set => _name = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
        }

        public string Surname
        {
            get => _surname;
            set => _surname = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
        }
        public double Sum
        {
            get { return _account; }
            set
            {
                _account = value;
                double res = Math.Round(_account, 2);
                Check($"On Account {res}");
            }
        }
    }
}
