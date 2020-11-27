using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov
{
    class Bank
    {
        public delegate void BankAccount(string phoneNumber, string Message);

        public event BankAccount Notify;

        private string _name;
        private string _surname;
        private string _phoneNumber;
        private string _id;
        private static double _1xBet = 2; //Ставка
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
                Notify?.Invoke(_phoneNumber, $"Acount Change {_Cash}");
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
        public Bank()
        {
            Console.WriteLine("Write you name");
            Name = Console.ReadLine();
            Console.WriteLine("Write you surname");
            Surname = Console.ReadLine();
            Console.WriteLine("Write you phone");
            _phoneNumber = Console.ReadLine();
            GetAge(); //Вызвал метод 79
            GetId(); //Вызвал метод 74
        }
        //Нужно сделать методы депозит, снять, ставка, и что-то ещё, чтобы всё работало.
        public void Deposit(int Value)
        {
            if (Value > _Min)
            {
                _Cash = _Cash + Value;
            }
            else Notify?.Invoke(_phoneNumber, "You can't add less than 10 000");
        }
        public void Withdraw(int Value)
        {
            if (Value < _Max)
            {
                _Cash = _Cash + Value;
            }
            else Notify?.Invoke(_phoneNumber, "You can't take more than 100 000");
        }
        public void Mirror(int Year)
        {
            double buff = _Cash;
            for (int i = 0; i < Year; i++)
            {
                buff = buff + buff * _1xBet / 100;
            }
            //Notify?.Invoke($"Your balance will be {buff} in {Year} years");
        }
        
        
    }
    class RunBank
    {
        public static void _Bunk()
        {
            Bank[] acc = new Bank[5];
            for (int i = 0; i < 1; i++)
            {
                
            }
        }
    }
}
