﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zamaliev
{
    public class Bank
    {
        public string _name;
        private string _surname;
        private string _phoneNumber;
        private string _id;
        private static double _stavka;
        private double _Cash;
        private static int _count = 1;
        private static int _Max = 100000;
        private static int _Min = 1000;
        private int _age;

        public string Name
        {
            get { return _name; }
            private set
            {
                if (value != "")
                {
                    value = value.Trim();
                    _name = value[0].ToString().ToUpper() + value.Substring(1);
                }
                else _name = "defualt";
            }
        }
        public string Surname
        {
            get { return _surname; }
            private set
            {
                if (value != "")
                {
                    value = value.Trim();
                    _surname = value[0].ToString().ToUpper() + value.Substring(1);
                }
                else _surname = "defualt";
            }
        }
        public int Age
        {
            get { return _age; }
            private set
            {
                _age = value;
            }
        }
        public string Id
        {
            get { return _id; }
        }
        public double Account
        {
            get { return _Cash; }
            private set
            {
                _Cash = value;

            }
        }
        public static int Count
        {
            get { return _count; }
        }
        private void GetId()
        {
            _id = _name + _surname + "_" + _count;
            _count = _count + 1;
        }
        private void GetAge()
        {
            Console.WriteLine("Write you birthday (dd mm yyyy)");
            string[] date = new string[3];
            date = Console.ReadLine().Split(" ");
            int day = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            int year = DateTime.Now.Year - int.Parse(date[2]) - 1;
            {
                if (DateTime.Now.Month >= month & DateTime.Now.Day >= day) Age = year + 1;
            }
        }

        
        
            public void Bank()
            {
                Console.WriteLine("Write you name");
                _name = Console.ReadLine();
                Console.WriteLine("Write you surname");
                Surname = Console.ReadLine();
                Console.WriteLine("Write you phone");
                _phoneNumber = Console.ReadLine();
                GetAge();
                GetId();
            }

            public void Deposit(int Value)
            {

            }
            public void Withdraw(int Value)
            {

            }
            public void Mirror(int Year)
            {

            }

        }
    }
}