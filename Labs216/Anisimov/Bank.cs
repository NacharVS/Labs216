﻿using System;

namespace Labs216.Anisimov
{
    class Bank
    {
        public delegate void BankAccount(string phoneNumber, string Message);

        public event BankAccount Notify = (phoneNumber, Message) => Console.WriteLine($"Было отправлено сообщение на номер: {phoneNumber}\nСообщение: {Message}\n");

        private string _name;
        private string _surname;
        private string _phoneNumber;
        private int _age;
        public string Id { get; private set; }
        private double _account;

        private static double _interestRate = 0.05;
        private int _period = 2;

        private double _cashBack;
        private static double _cahsBackRate = 0.01;
        private int _cashBackPeriod = 5;

        public static int Count { get; private set; } = 0;

        private static readonly int _Max = 1000000;
        private static readonly int _Min = 10000;
        private static readonly int _MinAge = 14;

        private DateTime _accountOpen;
        private DateTime _lastProfit;
        private DateTime _lastCASHBACK;

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
                else _name = "No data";
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
                else _surname = "No data";
            }
        }
        public int Age
        {
            get { return _age; }
            private set
            {
                if (value >= _MinAge)
                    _age = value;
                else
                    Console.WriteLine("Your age does not match the required");
            }
        }
        public double Account
        {
            get { return _account; }
            private set 
            {
                _account = Math.Round(value,2);
                Notify?.Invoke(_phoneNumber, $"Acount Change {_account}");
            }
        }
        private void GenId()
        {
            Id = _name + _surname + "_" + Count;
            Count = Count + 1;
        }
        private void GetAge()
        {
            Console.WriteLine("Write you birthday (dd.mm.yyyy)");
            string[] date = new string[3];
            date = Console.ReadLine().Split(".");
            int day = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            int year = DateTime.Now.Year - int.Parse(date[2]) - 1; 
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
            Console.WriteLine("Write you phone");
            _phoneNumber = Console.ReadLine();
            GetAge();
            GenId();
            _accountOpen = DateTime.Now;
            _lastProfit = _accountOpen;
            _lastCASHBACK = _accountOpen;
        }
        public Bank(string name, string surname, string phone)
        {
            Name = name;
            Surname = surname;
            _phoneNumber = phone;
            GenId();
            _accountOpen = DateTime.Now;
            _lastProfit = _accountOpen;
            _lastCASHBACK = _accountOpen;
        }
        public void Withdraw(int value)
        {
            if (value > _account)
            {
                Notify?.Invoke(_phoneNumber, $"You have only: {Account}");
                return;
            }
            if (value <= _Max)
            {
                Account = Account - value;
            }
            else Notify?.Invoke(_phoneNumber, "You can't take more than 100 000");
        }
        public void Deposit(int value)
        {
            if (value >= _Min)
            {
                Account = Account + value;
            }
            else Notify?.Invoke(_phoneNumber, "You can't add less than 10 000");
        }
        public void ShowProfit(int yaer)
        {
            double buff = _account;
            for (int i = 0; i < yaer;  i++)
            {
                buff += buff *_interestRate;
            }
            Notify?.Invoke(_phoneNumber, $"Your balance will be {buff} in {yaer} years");
        }
        public void Buy(int value)
        {
            Withdraw(value);
            Notify?.Invoke(_phoneNumber, $"Spend cash -- {value}");
            _cashBack += value * _cahsBackRate;
        }
        public void Buy(int value,string organization)
        {
            Withdraw(value);
            switch (organization)
            {
                case "Macdonalds":
                    _cashBack += value * (_cahsBackRate + 0.01);
                    Notify?.Invoke(_phoneNumber, $"Spend cash {value} in Macdonalds");
                    break;
                case "Steam":
                    _cashBack += value * (_cahsBackRate + 0.025);
                    Notify?.Invoke(_phoneNumber, $"Spend cash {value} in Steam");
                    break;
                case "Apple":
                    _cashBack += value * (_cahsBackRate + 0.02);
                    Notify?.Invoke(_phoneNumber, $"Spend cash {value} in Apple");
                    break;
                case "Paterochka":
                    _cashBack += value * (_cahsBackRate + 0.015);
                    Notify?.Invoke(_phoneNumber, $"Spend cash {value} in Paterochka");
                    break;
                default:
                    _cahsBackRate += value * (_cahsBackRate + 0.01);
                    Notify?.Invoke(_phoneNumber, $"Spend cash {value}");
                    break;
            }
        }
        public void CalculateProfit(DateTime timeNow)
        {
            while (((timeNow.Day - _lastProfit.Day) / _period) >= 1 || ((timeNow.Month - _lastProfit.Month) !=0))
            {
                _lastProfit += TimeSpan.FromDays(_period);
                Notify?.Invoke(_phoneNumber, $"Profit for {_lastProfit.Date}");
                Account += _account * _interestRate;
            }
        }
        public void GetCahsBack(DateTime timeNow)
        {
            if ((timeNow.Day - _lastCASHBACK.Day) >= _cashBackPeriod || ((timeNow.Month - _lastCASHBACK.Month) != 0))
            {
                Notify?.Invoke(_phoneNumber, $"Your get cahback {_cashBack}");
                Account += _cashBack;
                _lastCASHBACK = timeNow;
                _cashBack = 0;
            }
        }
        public void ChangeRate(double value)
        {
            _interestRate = value;
            Notify?.Invoke(_phoneNumber, $"New insert rate -- {_interestRate}");
        }
    }

    class RunBank
    {
        public static void RunBank1()
        {
            Bank[] acc = new Bank[1];
            for (int i = 0; i < 1; i++)
            {
                acc[i] = new Bank();
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"number {i + 1}");
                Console.WriteLine($"Name--{acc[i].Name}");
                Console.WriteLine($"Surname--{acc[i].Surname}");
                Console.WriteLine($"ID--{acc[i].Id}");
                Console.WriteLine($"Age--{acc[i].Age}");
                Console.WriteLine();
            }
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
                Console.WriteLine("What do you want: 1 -- Withdraw money || 2 -- Deposit money || 3 -- Check account || 4 -- Calculate deposit || 5 -- Change rate");
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
                        acc[acc_number].ShowProfit(int.Parse(Console.ReadLine()));
                        break;
                    case 5:
                        Console.WriteLine("How much:");
                        acc[acc_number].ChangeRate(double.Parse(Console.ReadLine()));
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
            }
        }

        public static void RunBank2() //Первый перегружен
        {
            Bank acc = new Bank("name","surname","88005553535");

            acc.Deposit(1000000);
            DateTime Time = DateTime.Now;
            Time += TimeSpan.FromDays(5);
            acc.CalculateProfit(Time);

            acc.Buy(10000);
            acc.Buy(15000);
            Time += TimeSpan.FromDays(1);
            acc.GetCahsBack(Time);

            acc.Buy(20000, "Apple");
            Time += TimeSpan.FromDays(5);
            acc.GetCahsBack(Time);

            Time += TimeSpan.FromDays(5);
            acc.CalculateProfit(Time);
        }
        //private static void Message(string PhoneNumber, string message)
        //{
        //    Console.WriteLine($"Было отправлено сообщение на номер: {PhoneNumber}");
        //    Console.WriteLine($"Сообщение: {message}");
        //    Console.WriteLine();
        //}
    }
}
