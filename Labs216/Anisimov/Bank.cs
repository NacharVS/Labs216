﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Labs216.Anisimov
{
    class Bank
    {
        public delegate void BankAccount(string message);

        public event BankAccount Notify;

        private string _name;
        private string _surname;
        private string _id;
        private static double InterestRate = 5;
        private double _account;
        private static int _count = 0;
        private static int _Max = 100000;
        private static int _Min = 10000;
        private static int _MinAge = 14;
        private int _age;

        public string Name
        {
            get { return _name; }
            set 
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
            set 
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
            set
            {
                if (value >= _MinAge)
                    _age = value;
                else
                    Console.WriteLine("Your age does not match the required");
            }
        }
        public string Id
        {
            get { return _id; }
        }
        public double Account
        {
            get { return _account; }
            set { _account = value; }
        }
        public static int Count
        {
            get { return _count; }
        }
        private void GenId()
        {
            _id = _name + _surname + "_" + _count;
            _count = _count + 1;
        }
        private void GetAge()
        {
            Console.WriteLine("Write you birthday");
            Console.WriteLine("Day:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Mounth: (Example : may)");
            int month = 0;
            switch (Console.ReadLine())
            {
                case "январь":
                    month = 1;
                    break;
                case "февраль":
                    month = 2;
                    break;
                case "март":
                    month = 3;
                    break;
                case "апрель":
                    month = 4;
                    break;
                case "май":
                    month = 5;
                    break;
                case "июнь":
                    month = 6;
                    break;
                case "июль":
                    month = 7;
                    break;
                case "август":
                    month = 8;
                    break;
                case "сентябрь":
                    month = 9;
                    break;
                case "октябрь":
                    month = 10;
                    break;
                case "ноябрь":
                    month = 11;
                    break;
                case "декабрь":
                    month = 12;
                    break;
            }
            Console.WriteLine("Year:");
            int year = int.Parse(Console.ReadLine());
            year = DateTime.Now.Year - year - 1; 
            {
                if (DateTime.Now.Month >= month & DateTime.Now.Day >= day) Age = year + 1;
                else Age = year;
            }
        }


        public Bank()
        {
            Console.WriteLine("Write you name");
            Name = Console.ReadLine();
            Console.WriteLine("Write you surname");
            Surname = Console.ReadLine();
            GetAge();//Отдельный метод для запроса дня рождения и расчета возраста (мне так удобнее)
            GenId();
        }
        public void Withdraw(int value)
        {
            if (value > _account)
            {
                Notify?.Invoke($"You have only: {Account}");
                return;
            }
            if (value <= _Max)
            {
                Account = Account - value;
                Notify?.Invoke($"Now your balance is: {Account}");
            }
            else Notify?.Invoke("You can't take more than 100 000");
        }
        public void Deposit(int value)
        {
            if (value >= _Min)
            {
                _account = _account + value;
                Notify?.Invoke($"Now your balance is: {Account}");
            }
            else Notify?.Invoke("You can't add less than 10 000");
        }
        public void Calculate(int year)
        {
            double buff = _account;
            for (int i = 0; i < year;  i++)
            {
                buff = buff + buff *InterestRate/100;
            }
            Notify?.Invoke($"Your balance will be {buff} in {year} years");
        }
    }
    class Run
    {
        public static void _Bank()
        {
            Bank[] acc = new Bank[3];
            for (int i = 0; i < 1; i++)
            {
                acc[i] = new Bank();
                acc[i].Notify += Message;
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"number {i + 1}");
                Console.WriteLine($"Name--{acc[i].Name}");
                Console.WriteLine($"Surname--{acc[i].Surname}");
                Console.WriteLine($"ID--{acc[i].Id}");
                Console.WriteLine($"Age--{acc[i].Age}");
                Console.WriteLine();
            } // Это выврд для проверки правильно ли создаються аккаунты и выбора с каким аккаунтом работать
            int acc_number = 0;
            while (true)
            {
                Console.WriteLine("Which account do you want to work with");
                acc_number = int.Parse(Console.ReadLine()) - 1;
                if (acc_number <= Bank.Count - 1) break;
                else Console.WriteLine("Wrong number");
            }
            while (true)
            {
                Console.WriteLine("What do you want: 1 -- Withdraw money || 2 -- Deposit money || 3 -- Check account || 4 -- Calculate deposit");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("How much:");
                        acc[acc_number].Withdraw(int.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("How much:");
                        acc[acc_number].Deposit(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine(acc[acc_number].Account);
                        break;
                    case 4:
                        Console.WriteLine("How many years to calculate");
                        acc[acc_number].Calculate(int.Parse(Console.ReadLine()));
                        break;
                }
                Console.WriteLine("Continue y/n");
                if (Console.ReadLine() == "n")
                    break;
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"number {i + 1}");
                Console.WriteLine($"Name--{acc[i].Name}");
                Console.WriteLine($"Surname--{acc[i].Surname}");
                Console.WriteLine($"ID--{acc[i].Id}");
                Console.WriteLine($"Money--{acc[i].Account}");
                Console.WriteLine($"Age--{acc[i].Age}");
                Console.WriteLine();
            }// Это вывод для проверки правильно ли программа работала с данными
        }
        private static void Message(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
