using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev.Bank_collection
{
    abstract class Klient
    {
        private string _name;
        private string _surname;

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

        public virtual void GetInform()
        {
            Console.WriteLine($"li4nostb klienta: {Name}{Surname}");
        }
        class Clerk : Klient
        {
            private static int _otdel;

            public override void GetInform()
            {
                Console.WriteLine($"li4nostb klienta: {Name}{Surname}");
                Console.WriteLine($"otdlenie: {_otdel}");
                _otdel += 1;
            }
            class Bank : Klient
            {
                public delegate void Izmenitstavka(double stavka);

                public event Izmenitstavka Notify = (double stavka) => Console.WriteLine($"Novaya stavka{stavka}");

                public delegate void OnAccount(string reklama);

                public event OnAccount Check = (string reklama) => Console.WriteLine(reklama);

                private static DateTime _accountOpeningDate = DateTime.Now;
                private static DateTime _lastProfit = _accountOpeningDate;


                private string _id;
                private static double _stavka = 0.25;
                private double _account;
                private static int _minPut = 250;
                private static int _maxTake = 25000000;
                private static int _count;
                private static double _cashbackRate = 0.05;
                private static double _cashbackRateOrganizationOne = 0.11;
                private static double _cashbackRateOrganizationTwo = 0.18;
                private static double _cashbackRateOrganizationThree = 0.25;
                private int Year { get; set; }
                private int Month { get; set; }


            }

            public double Stavka
            {
                get { return Stavka; }
                private set
                {
                    Stavka = value;
                    Notify?.Invoke(Stavka);
                }
            }

            public double Account
            {
                get { return _Account; }
                set
                {
                    _Account = value;
                    double res = Math.Round(_Account, 2);
                    Check($"На аккаунте {res}");
                }
            }

            public void NewRate()
            {
                Console.WriteLine("Novaya stavka:");
                double rate = double.Parse((Console.ReadLine()));
                Stavka = rate;
            }

            public void Installed(DateTime timeNow, int period)
            {

                for (int j = 0; j < (timeNow.Second - _lastProfit.Second) / period; j++)
                {

                    _account += Account * Stavka;
                    Check?.Invoke($"На счету прибыль {_Account}");
                }

                _lastProfit = timeNow;
            }

            public void Buy(int sum)
            {
                _account -= sum;
                Check?.Invoke($"Купить: {sum}");
                _account += sum * _cashbackRate;
                Check?.Invoke($"Кэшбэк: {sum * _cashbackRate};kesh: {_account}");
            }

            public void Buy(int sum, string nameOrganization)
            {
                if (nameOrganization == "One")
                {
                    _account -= sum;
                    Check?.Invoke($"Купить: {sum}");
                    _account += sum * _cashbackRateOrganizationOne;
                    Check?.Invoke($"Кэшбэк: {sum * _cashbackRateOrganizationOne}; kesh: {_account}");
                }
                else if (nameOrganization == "Two")
                {
                    _account -= sum;
                    Check?.Invoke($"Купить: {sum}");
                    _account += sum * _cashbackRateOrganizationOne;
                    Check?.Invoke($"Кэшбэк: {sum * _cashbackRateOrganizationTwo}; kesh: {_account}");
                }
                if (nameOrganization == "Three")
                {
                    _account -= sum;
                    Check?.Invoke($"Купить: {sum}");
                    _account += sum * _cashbackRateOrganizationOne;
                    Check?.Invoke($"Кэшбэк: {sum * _cashbackRateOrganizationThree}; kesh: {_account}");
                }

            }

        }
    }
}
