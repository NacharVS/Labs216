using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev._1
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
        }
    }
}
