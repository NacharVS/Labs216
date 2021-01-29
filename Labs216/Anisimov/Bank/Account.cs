using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Labs216.Anisimov.Bank
{
    class Account
    {
        public delegate void BankAccount(string phoneNumber, string Message);
        public static event BankAccount Notify = (phoneNumber, Message) =>
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
        public ObjectId Id { get; private set; }
        private double _sum;

        public double InterestRate { get; private set; } = 5;
        private static readonly int _period = 1;

        public double CashBack { get; private set; }
        private static readonly double _cahsBackRate = 0.01;
        private static readonly int _cashBackPeriod = 5;

        public DateTime AccountOpen { get; private set; }
        public DateTime LastProfit { get; private set; }
        public DateTime LastCASHBACK { get; private set; }

        private bool IsNotDBcall; //При получении аккаунта из базы данных, прогоняються все set

        private AccountContext db = AccountContext.getInstanse();

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
                if(IsNotDBcall)
                    Notify?.Invoke(PhoneNumber, $"Acount Change {_sum}");
                IsNotDBcall = true;
            }
        }

        public Account(string name, string surname, string phone, int age)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phone;
            Age = age;
        }

        public void Open(DateTime time)
        {
            AccountOpen = time;
            LastProfit = time;
            LastCASHBACK = time;
            Notify?.Invoke(PhoneNumber, $"Accoun was opened\n");

            db.Create(this).GetAwaiter().GetResult();
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
            CashBack += sum * (_cahsBackRate + BonusRate);
        }
        public void ChangeRate(double newRate)
        {
            InterestRate = newRate;
            Notify?.Invoke(PhoneNumber, $"InterestRate changed -- {newRate}");
        }
        public void Calculate(DateTime TimeNow)
        {
            if (Sum == 0)
            {
                LastProfit = TimeNow;
                return;
            }
            while (((TimeNow.Day - LastProfit.Day) / _period) >= 1 || ((TimeNow.Month - LastProfit.Month) != 0))
            {
                LastProfit += TimeSpan.FromDays(_period);
                Notify?.Invoke(PhoneNumber, $"Profit for {LastProfit.Date}");
                Sum += _sum * InterestRate/100;
            }
        }
        public void GetCashBack(DateTime TimeNow)
        {
            if (CashBack == 0)
            {
                LastCASHBACK = TimeNow;
                return;
            }

            if ((TimeNow.Day - LastCASHBACK.Day) >= _cashBackPeriod || ((TimeNow.Month - LastCASHBACK.Month) != 0))
            {
                Notify?.Invoke(PhoneNumber, $"Your get cahback {CashBack}");
                Sum = _sum +CashBack;
                LastCASHBACK = TimeNow;
                CashBack = 0;
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
    }
}