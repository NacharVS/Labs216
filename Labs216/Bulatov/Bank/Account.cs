using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Bank
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

        AccountContext db = new AccountContext();

        private string _name;
        private string _surname;
        public string PhoneNumber { get; private set; }
        public int Age { get; private set; }
        public ObjectId Id { get; private set; }
        private double _sum;

        private static double _interestRate = 0.05;
        private readonly int _period = 1;

        private double _cashBack;
        private static readonly double _cahsBackRate = 0.01;
        private readonly int _cashBackPeriod = 5;

        [BsonIgnore]
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
        //private void GenId()
        //{
        //    Id = ++Count;
        //}

        public Account(string name, string surname, string phone, int age)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phone;
            Age = age;
        }

        public void Open(DateTime time)
        {
            //GenId();
            _accountOpen = time;
            _lastProfit = time;
            _lastCASHBACK = time;
            db.AddAccount(this).GetAwaiter().GetResult();
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
            if (Sum == 0)
            {
                _lastProfit = TimeNow;
                return;
            }
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
            {
                _lastCASHBACK = TimeNow;
                return;
            }

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
            var list = db.GetAccounts().GetAwaiter().GetResult();

            foreach (var item in list)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"name\t{item.Name}\nsurname\t{item.Surname}\nphone\t{item.PhoneNumber}\nage\t{item.Age}\nid\t{item.Id}\nsum\t{item.Sum}");
                Console.ForegroundColor = tmp;
            }
        }
    }
}
