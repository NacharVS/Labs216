﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Stepanov.Bank
{
    class Account
    {
        public delegate void BankAccount(string phoneNumber, string Message);
        public event BankAccount Notify = (phoneNumber, Message) =>
        {
            ConsoleColor tmp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Было отправлено сообщение на номер: {phoneNumber}\nСообщение: {Message}\n");
            Console.ForegroundColor = tmp;
        };

        private string _name;
        private string _surname;
        public string PhoneNumber { get; private set; }
        public int Age { get; private set; }
        public int Id { get; private set; }
        private double _sum;

        private static double _interestRate = 0.05;
        private readonly int _period = 2;

        private double _cashBack;
        private static readonly double _cahsBackRate = 0.01;
        private readonly int _cashBackPeriod = 5;

        private static int Count;

        private DateTime _accountOpen;
        private DateTime _lastProfit;
        private DateTime _lastCASHBACK;

        public string Name
        {
            get { return _name; }
            private set
            {
                value = value.Trim();
                _name = value[0].ToString().ToUpper() + value.Substring(1);
            }
        }
        public string Surname
        {
            get { return _surname; }
            private set
            {
                value = value.Trim();
                _surname = value[0].ToString().ToUpper() + value.Substring(1);

            }
        }
        public double Sum
        {
            get { return _sum; }
            private set
            {
                _sum = Math.Round(value, 2);
                Notify?.Invoke(PhoneNumber, $"Acount Change {_sum}");
            }
        }
        private void GenId()
        {
            Id = ++Count;
        }

        public Account(string name, string surname, string phone, int age)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phone;
            Age = age;
        }

        public void Open()
        {
            GenId();
            _accountOpen = DateTime.Now;
            _lastProfit = _accountOpen;
            _lastCASHBACK = _accountOpen;
            Notify?.Invoke(PhoneNumber, $"Accoun was opened\nId--{Id}\n");
        }
        public void Put(int sum)
        {
            Sum += sum;
        }
        public void Withdraw(int sum)
        {
            Sum -= sum;
        }
        public void Buy(int sum, ref double BonusRate)
        {
            _cashBack += sum * (_cahsBackRate + BonusRate);
        }
        public void ChangeRate(double newRate)
        {
            _interestRate = newRate;
            Notify?.Invoke(PhoneNumber, $"InterestRate changed -- {newRate}");
        }
        public void Calculate(DateTime TimeNow)
        {
            while (((TimeNow.Day - _lastProfit.Day) / _period) >= 1 || ((TimeNow.Month - _lastProfit.Month) != 0))
            {
                _lastProfit += TimeSpan.FromDays(_period);
                Notify?.Invoke(PhoneNumber, $"Profit for {_lastProfit.Date}");
                Sum += _sum * _interestRate;
            }
        }
        public void GetCashBack(DateTime TimeNow)
        {
            if (_cashBack == 0)
                return;

            if ((TimeNow.Day - _lastCASHBACK.Day) >= _cashBackPeriod || ((TimeNow.Month - _lastCASHBACK.Month) != 0))
            {
                Notify?.Invoke(PhoneNumber, $"Your get cahback {_cashBack}");
                Sum = _sum + _cashBack;
                _lastCASHBACK = TimeNow;
                _cashBack = 0;
            }
        }
        public void Close()
        {
            Notify?.Invoke(PhoneNumber, $"Account with Id {Id} closed");
        }
        public void EditInfo(int choose, string newValue)
        {
            switch (choose)
            {
                case 1:
                    Name = newValue;
                    break;
                case 2:
                    Surname = newValue;
                    break;
                case 3:
                    PhoneNumber = newValue;
                    break;
                case 4:
                    Age = int.Parse(newValue);
                    break;
            }
        }

        public void GetInfo()
        {
            ConsoleColor tmp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"name\t{Name}\nsurname\t{Surname}\nphone\t{PhoneNumber}\nage\t{Age}\nid\t{Id}\nsum\t{Sum}");
            Console.ForegroundColor = tmp;
        }
    }
}