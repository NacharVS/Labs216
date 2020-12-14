using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Labs216.Shakirov
//{
//    abstract class Person
//    {
//        private string _name;
//        private string _surname;

//        public string Name
//        {
//            get => _name;
//            set => _name = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
//        }

//        public string Surname
//        {
//            get => _surname;
//            set => _surname = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
//        }

//        public virtual void GetInform()
//        {
//            Console.WriteLine($"Your name: {Name}{Surname}");
//        }

//        class Clerk : Person
//        {
//            private static int _departament;

//            public override void GetInform()
//            {
//                Console.WriteLine($"Ваше имя: {Name}{Surname}");
//                Console.WriteLine($"Ваш департамент: {_departament}");
//                _departament += 1;

//            }
//        }

//        class Bank : Person
//        {
//            public delegate void ChangeRate(double rate);

//            public event ChangeRate Notify = (double rate) => Console.WriteLine($"Новая ставка{rate}");

//            public delegate void OnAccount(string message);

//            public event OnAccount Check = (string message) => Console.WriteLine(message);

//            private static DateTime _accountOpeningDate = DateTime.Now;
//            private static DateTime _lastProfit = _accountOpeningDate;

//            private string _id;
//            private static double _stavka = 0.06;
//            private double _account;
//            private static int _minPut = 1000;
//            private static int _maxTake = 10000000;
//            private static int _count;
//            private static double _cashbackRate = 0.05;
//            private static double _cashbackRateOrganizationOne = 0.10;
//            private static double _cashbackRateOrganizationTwo = 0.15;
//            private static double _cashbackRateOrganizationThree = 0.25;
//            private int Year { get; set; }
//            private int Month { get; set; }



//            public double Stavka
//            {
//                get { return _stavka; }
//                private set
//                {
//                    _stavka = value;
//                    Notify?.Invoke(_stavka);
//                }
//            }

//            public double Account
//            {
//                get { return _account; }
//                set
//                {
//                    _account = value;
//                    double res = Math.Round(_account, 2);
//                    Check($"На аккаунте {res}");
//                }
//            }

//            public void NewRate()
//            {
//                Console.WriteLine("Написать новую ставку:");
//                double rate = double.Parse((Console.ReadLine()));
//                Stavka = rate;
//            }

//            public void Installed(DateTime timeNow, int period)
//            {

//                for (int j = 0; j < (timeNow.Second - _lastProfit.Second) / period; j++ )
//                {

//                    _account += Account * Stavka;
//                    Check?.Invoke($"На счету прибыль {_account}");
//                }

//                _lastProfit = timeNow;
//            }

//            public void Buy(int sum)
//            {
//                _account -= sum;
//                Check?.Invoke($"Купить: {sum}");
//                _account += sum * _cashbackRate;
//                Check?.Invoke($"Кэшбэк: {sum * _cashbackRate}; Кэшбэк на счете: {_account}");
//            }

//            public void Buy(int sum, string nameOrganization)
//            {
//                if (nameOrganization == "One")
//                {
//                    _account -= sum;
//                    Check?.Invoke($"Купить: {sum}");
//                    _account += sum * _cashbackRateOrganizationOne;
//                    Check?.Invoke($"Кэшбэк: {sum * _cashbackRateOrganizationOne}; Кэшбэк на счете: {_account}");
//                }
//                else if (nameOrganization == "Two")
//                {
//                    _account -= sum;
//                    Check?.Invoke($"Купить: {sum}");
//                    _account += sum * _cashbackRateOrganizationOne;
//                    Check?.Invoke($"Кэшбэк: {sum * _cashbackRateOrganizationTwo}; Кэшбэк на счете: {_account}");
//                }
//                else if (nameOrganization == "Three")
//                {
//                    _account -= sum;
//                    Check?.Invoke($"Купить: {sum}");
//                    _account += sum * _cashbackRateOrganizationOne;
//                    Check?.Invoke($"Кэшбэк: {sum * _cashbackRateOrganizationThree}; Кэшбэк на счете: {_account}");
//                }

//            }
//            public override void GetInform()
//            {
//                Console.WriteLine($"Ваше имя: {Name} {Surname}");
//                Console.WriteLine($"Ваше ID: {GenerationId()}");
//                Console.WriteLine($"Ваше аккаунт: {Account}");
//                Console.WriteLine($"Ваша интересующая ставка: {Stavka}");
//            }
//            public string GeneationId()
//            {
//                _id = Name + Surname + _count;
//                _count += 1;
//                return _id;
//            }
//            public void Deposit()
//            {
//                Console.WriteLine("Как хотите внести депзит");
//                int value = int.Parse(Console.ReadLine());

//                if (value < _minPut)
//                    Console.WriteLine("значние меньше минимального");
//                else
//                    Account += value;
//            }
//            public void Withdraw()
//            {
//                Console.WriteLine()
//            }
        //}
