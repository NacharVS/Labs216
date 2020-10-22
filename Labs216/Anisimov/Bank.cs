using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Labs216.Anisimov
{
    class Bank
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _InterestRate = 5;
        private double _account;
        private static int _count = 0;

        public string Name
        {
            get { return _name; }
            set 
            {
                value = value.Trim();
                _name = value[0].ToString().ToUpper() + value.Substring(1);
            }
        }
        public string Surname
        {
            get { return _surname; }
            set 
            {
                value = value.Trim();
                _surname = value[0].ToString().ToUpper() + value.Substring(1);
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
        private void GenId() // Удобнее менять логику генерации id
        {
            _id = _name + _surname + "_" + _count;
            _count = _count + 1;
        }


        public Bank()
        {
            Console.WriteLine("Write you name");
            Name = Console.ReadLine();
            Console.WriteLine("Write you surname");
            Surname = Console.ReadLine();
            GenId();
            Console.WriteLine($"Hello, {_name} {_surname}, your bank account is ready.");
        }
        public void Withdraw(int value)
        {
            if (value > _account)
            {
                Console.WriteLine($"You have only {_account}");
                return;
            }
            if (value <= 100000)
            {
                _account = _account - value;
                Console.WriteLine($"Now your have {_account} on the bank account");
            }
            else Console.WriteLine("You can take more than 100 000");
        }
        public void Deposit(int value)
        {
            if (value >= 10000)
            {
                _account = _account + value;
                Console.WriteLine($"Now your have {_account} on the bank account");
            }
            else Console.WriteLine("You can add les than 10 000");
        }
        public void Calculate(int year)
        {
            double buff = _account;
            for (int i = 0; i < year;  i++)
            {
                buff = buff + buff * 5 / 100;
            }
            Console.WriteLine(buff);
        }
    }
}
