using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Labs216.Anisimov
{
    class Bank
    {
        public static void Labchek()//Медот для проверки практики, приватность становиться бесполезной, но так проверять легче
        {
            Bank acc1 = new Bank();
            Console.WriteLine("What do you want: 1 -- Withdraw money || 2 -- Deposit money || 3 -- Check account || 4 -- Calculate deposit");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }
        private string _name;
        private string _surname;
        private string _id;
        private static double _InterestRate = 5;
        private double _account;
        private static int _count;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
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
        public Bank()
        {
            Console.WriteLine("Write you name");
            _name = Console.ReadLine();
            Console.WriteLine("Write you surname");
            _surname = Console.ReadLine();
            _id = _name + _surname + _count;
            _count = +1;
            Console.WriteLine($"Hello, {_name} {_surname}, your bank account is ready, its id {_id} and you have {_account} y.e on it");//id выводиться просто для проверки что все правильно создаеться
        }
    }
}
