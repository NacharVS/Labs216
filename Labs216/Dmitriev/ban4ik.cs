using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev
{
    class ban4ik
    {

        public delegate void BankAccount(string phoneNumber, string Message);

     

        public event BankAccount Notify;

        private string _firstname;
        private string _surname;
        private string _phoneNumber;
        private static double _interestRate = 5;
        private double _account; private double _cashBack;

        private static double _cahsBackRate = 0.25;
        private static int _Max = 250000;
        private static int _Min = 11000;
        private static int _MinAge = 14;
        private int _age;

        public string Name
        {
            get { return _firstname; }
            private set
            {
                if (value != "")
                {
                    value = value.Trim();
                    _firstname = value[0].ToString().ToUpper() + value.Substring(1);
                }
                else _firstname = "нет данных ";
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
                else _surname = "нет данных";
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
                    Console.WriteLine("возраст не допускаемый");
            }
        }

        public double Account
        {
            get { return _account; }
            private set
            {
                _account = value;
                Notify?.Invoke(_phoneNumber, $"Acount  {_account}");
            }
        }

        public void PeriodProfit(DateTime currenTime,int period, object _accounOpened, int _rate, int Sum)
        {
            int deltaTime = currenTime.Second - _accounOpened.Second;
            for (int i = 0; i < deltaTime / period; i++)
            {
                Sum += (int)(Sum * _rate);
            }
        }

        private void GetAge()
        {
            Console.WriteLine("введите день рождение (число.месяц.год)");
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
        public ban4ik()
        {
            Console.WriteLine("Введите имя");
            Name = Console.ReadLine();
            Console.WriteLine("введите фамилию");
            Surname = Console.ReadLine();
            Console.WriteLine("введите номер телефона ");
            _phoneNumber = Console.ReadLine();
            GetAge();

        }
        public void Withdraw(int value)
        {
            if (value > _account)
            {
                Notify?.Invoke(_phoneNumber, $"аккаунт есть : {Account}");
                return;
            }
            if (value <= _Max)
            {
                Account = Account - value;
            }
            else Notify?.Invoke(_phoneNumber, "максимальное 250000");
        }
        public void Deposit(int value)
        {
            if (value >= _Min)
            {
                Account = Account + value;
            }
            else Notify?.Invoke(_phoneNumber, "минимальное 11000");
        }
        public void Calculate(int year)
        {
            double buff = _account;
            for (int i = 0; i < year; i++)
            {
                buff = buff + buff * _interestRate / 100;
            }
            Notify?.Invoke(_phoneNumber, $"стольео будет {buff} через {year} лет");
        }

        class RunBank
        {
            public static void _Bank()
            {
                Bank[] acc = new Bank[1];
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
                    Console.WriteLine($"Age--{acc[i].Age}");
                    Console.WriteLine();
                }
            }

            private static void Message(string PhoneNumber, string message)
            {
                Console.WriteLine($"Было отправлено сообщение на номер: {PhoneNumber}");
                Console.WriteLine($"Сообщение: {message}");
                Console.WriteLine();
            }
        }

        internal class Bank
        {
            internal Action<string, string> Notify;
            internal object Name;
            internal object Age;

            public object Surname { get; internal set; }
        }
    }
}