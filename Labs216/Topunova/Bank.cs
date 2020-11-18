using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Labs216.Topunova
{
    class Bank
    {
        private string _name;
        private string _surname;
        private string _id;
        private string _stavka = 0.035;
        private string _score;
        private string _age;
        private string SetName;
        private static double _rate;
        private static _Bank.Accounte; 
        private double _paymentAccount;
        private DateTime _accounteOpenDate;
        private string _phoneNumber;
        private string _keshBak;
        private object _phonenNumber;

        public void Infa()
        {
            Console.WriteLine("Введите: {_name}, {_surname}");
            Console.WriteLine("Введите: {_id}");
            Console.WriteLine("const = _rate");
        }
        public void SetName(string newName)
        {
            _name = newName.Trim();
            var firstLetter = newName[0];
            var otherLetter = newName.Remove(0, 1);
            _name = (firstLetter.ToString().ToUpper() + otherLetter);
        }
        public void SetSurname(string newSurname)
        {
            newSurname = newSurname.Trim();
            var firstLatter = newSurname[0];
            var otherLatter = newSurname(0, 1);
            newSurname = (firstLatter.ToString().ToUpper() + otherLatter);
        }
        public void SetId(string newId)
        {
            newId = newId.Trim();
            var firstLatter = newId[0];
            var otherLatter = newId(0, 1);
            newId = (firstLatter.ToString().ToUpper() + otherLatter);
        }
        public static void Go()
        {
            Bank bank = new Bank();
            Console.WriteLine("Введите: ");
            bank._name = Console.ReadLine();
            Console.WriteLine();
            bank._surname = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Введите: ");
            double month = double.Parse(Console.ReadLine());
            double month1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите: ");
            double year = double.Parse(Console.ReadLine());
            double year1 = double.Parse(Console.ReadLine());

            double now = DateTime.Now.Year;
            double mounth = DateTime.Now.Month;

            if (now - bank._year >= 14 && month > bank._month)
            {
                Console.WriteLine("Access");
                while ()
                {
                    Console.WriteLine();
                    Console.WriteLine("");
                    int.choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("");
                            double with = double.Parse(Console.ReadLine());
                            if (_rate > with)
                            {
                                Console.WriteLine("-");
                            }
                            else
                            {
                                Console.WriteLine($"{_rate -= with} money");
                            }
                            else
                            {
                                Console.WriteLine($"{_rate} money");
                            }
                            break;
                        case "2":
                            Console.WriteLine("1000");
                            double put = double.Parse(Console.ReadLine());
                            if (put > 1000)
                            {
                                Console.WriteLine("-");
                            }
                            else
                            {
                                Console.WriteLine($"{_rate += put} money");
                            }
                            break;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            _Bank.Account acc1 = new _Bank.Account(500, "_phoneNumber");
            acc1.RateChangedEvent += _rateChangednotify;
            acc1.RateChange(0.047);
        }

        public void _phoneNumber()
        {
            _phonenNumber = Console.WriteLine("Введите номер: ");
        }
        public void BankAccount(int sum, string phoneNumber)
        {
            _sum = sum;
            _phoneNumber = phoneNumber;
        }

        public void PeriodProfit(DateTime currentTime, int period, sum)
        {
            int deltaTime = currentTime.Second - _accounOpenDate.Second;
            for (int i = 0; i < deltaTime / period; i++)
            {
                Sum += (int)(Sum * _rate);
            }
        }
    }
}

