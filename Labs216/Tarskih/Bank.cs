using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih
{
    class Bank
    {
        List<Bank> account = new List<Bank>();

        public delegate void ChangeRate(double rate);

        public event ChangeRate Notify = (double rate) => Console.WriteLine($"New rate{rate}");

        public delegate void OnAccount(string message);

        public event OnAccount Message = (string message) => Console.WriteLine(message);

        private static DateTime _accountOpeningDate = DateTime.Now;
        private static DateTime _lastProfit = _accountOpeningDate;

        private string _name;
        private string _surname;
        private int _id;
        private int _year;
        private int _month;
        private string _phoneNumber;
        private static double _stavka = 0.06;
        private double _account;
        private static int _minPut = 1000;
        private static int _maxTake = 10000000;
        private static int _count;
        private static double _cashbackRate = 0.05;
        private static double _cashbackRateOrganizationOne = 0.10;
        private static double _cashbackRateOrganizationTwo = 0.15;
        private static double _cashbackRateOrganizationThree = 0.25;
        private int Year
        {
            get => _year;
            set
            {
                _year = value;
                CheckAge();
            }
        }
        private int Month
        {
            get => _month;
            set
            {
                _month = value;
                CheckAge();
            }
        }
        public Bank(string name, string surname, int year, int month, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            Year = year;
            Month = month;
            PhoneNumber = phoneNumber;

            GenerationId();
        }
        public string Name
        {
            get => _name;
            set => _name = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
        }

        public string Surname
        {
            get => _surname;
            set => _surname = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
        }
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }

        public double Stavka
        {
            get { return _stavka; }
            private set
            {
                _stavka = value;
                Notify?.Invoke(_stavka);
            }
        }

        public double Account
        {
            get { return _account; }
            set
            {
                _account = value;
                double res = Math.Round(_account, 2);
                Message($"On Account {res}");
            }
        }

        public void NewRate(int rate)
        {
            Stavka = rate;
        }

        public void Instilled(DateTime timeNow, int period)
        {

            for (int j = 0; j < (timeNow.Second - _lastProfit.Second) / period; j++)
            {

                _account += Account * Stavka;
                Message?.Invoke($"On Account with profit {_account}");
            }

            _lastProfit = timeNow;
        }

        public void Buy(int sum)
        {
            Withdraw(sum);
            Message?.Invoke($"Buy: {sum}");
            _account += sum * _cashbackRate;
            Message?.Invoke($"CashBack: {sum * _cashbackRate}; On Account with CashBack: {_account}");
        }

        public void Buy(int sum, string nameOrganization)
        {
            if (nameOrganization == "One")
            {
                _account -= sum;
                Message?.Invoke($"Buy: {sum}");
                _account += sum * _cashbackRateOrganizationOne;
                Message?.Invoke($"CashBack: {sum * _cashbackRateOrganizationOne}; On Account with CashBack: {_account}");
            }
            else if (nameOrganization == "Two")
            {
                _account -= sum;
                Message?.Invoke($"Buy: {sum}");
                _account += sum * _cashbackRateOrganizationTwo;
                Message?.Invoke($"CashBack: {sum * _cashbackRateOrganizationTwo}; On Account with CashBack: {_account}");
            }
            else if (nameOrganization == "Three")
            {
                _account -= sum;
                Message?.Invoke($"Buy: {sum}");
                _account += sum * _cashbackRateOrganizationThree;
                Message?.Invoke($"CashBack: {sum * _cashbackRateOrganizationThree}; On Account with CashBack: {_account}");
            }

        }
        public void GetInform()
        {
            Console.WriteLine($"Your name: {Name} {Surname}");
            Console.WriteLine($"Your ID: {_id}");
            Console.WriteLine($"Your account: {Account}");
            Console.WriteLine($"Your interest rate: {Stavka}");
        }
        public void CheckAge()
        {
            int age = DateTime.Now.Year - Year;
            if (DateTime.Now.Month >= Month) age += 1;

            if (age < 16)
                throw new Exception();
        }
        public void GenerationId()
        {
            _id = ++_count;
        }
        public void Put(int value)
        {
            if (value < _minPut)
                Message.Invoke($"Value less then minimum ({_minPut})");
            else
                Account += value;
        }
        public void Withdraw(int value)
        {
            if (value > _maxTake)
                Message.Invoke($"Value is greater then maximum ({_maxTake})");

            if (Account > value)
            {
                Account -= value;
            }

            else
                Message.Invoke("Insufficient funds on the bill");
        }

        public void ChangeName(List<Bank> account, int ID, string newName)
        {
            foreach (var item in account)
            {
                if (item._id == ID)
                {
                    item.Name = newName;
                }
            }
        }
        public void ChangeSurname(List<Bank> account, int ID, string newSurname)
        {
            foreach (var item in account)
            {
                if (item._id == ID)
                {
                    item.Name = newSurname;
                }
            }
        }
        public void ChangePhone(List<Bank> account, int ID, string newPhone)
        {
            foreach (var item in account)
            {
                if (item._id == ID)
                {
                    item.Name = newPhone;
                }
            }
        }
        public void ChangeYear(List<Bank> account, int ID, string newYear)
        {
            foreach (var item in account)
            {
                if (item._id == ID)
                {
                    item.Name = newYear;
                }
            }
        }
        public void ChangeMonth(List<Bank> account, int ID, string newMonth)
        {
            foreach (var item in account)
            {
                if (item._id == ID)
                {
                    item.Name = newMonth;
                }
            }
        }
    }
}
