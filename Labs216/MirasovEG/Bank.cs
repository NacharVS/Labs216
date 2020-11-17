using System;
using System.Threading;

namespace Labs216.MirasovEG
{
    abstract class Person
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
            Console.WriteLine($"Your name: {Name}{Surname}");
        }
    }

    class Clerk : Person
    {
        private static int _department;

        public override void GetInform()
        {
            Console.WriteLine($"Your name: {Name}{Surname}");
            Console.WriteLine($"Your department: {_department}");
            _department += 1;
        }
    }

    class Bank : Person
    {
        public delegate void ChangeRate(double rate);

        public event ChangeRate Notify;

        public delegate void OnAccount(string message);

        public event OnAccount Check;

        private static DateTime _accountOpeningDate = DateTime.Now;
        private static DateTime _lastProfit = _accountOpeningDate;


        private string _id;
        private static double _stavka = 0.06;
        private double _account;
        private static int _minPut = 1000;
        private static int _maxTake = 10000000;
        private static int _count;
        private static double _cashbackRate = 0.05;
        
        private int Year { get; set; }
        private int Month { get; set; }


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
                Check?.Invoke($"On Account {res}");
            }
        }

        public void NewRate()
        {
            Console.WriteLine("Write new Rate:");
            double rate = double.Parse((Console.ReadLine()));
            Stavka = rate;
        }

        public void Instilled(DateTime timeNow, int period)
        {

            for (int j = 0; j < (timeNow.Second - _lastProfit.Second) / period; j++)
            {

                _account += Account * Stavka;
                Check?.Invoke($"On Account with profit {_account}");
            }

            _lastProfit = timeNow;
        }

        public void Buy(int sum)
        {
            _account -= sum;
            Check?.Invoke($"Buy: {sum}");
            _account += sum * _cashbackRate;
            Check?.Invoke($"CashBack: {sum * _cashbackRate}; On Account with CashBack: {_account}");
        }
        public override void GetInform()
        {
            Console.WriteLine($"Your name: {Name} {Surname}");
            Console.WriteLine($"Your ID: {GenerationId()}");
            Console.WriteLine($"Your account: {Account}");
            Console.WriteLine($"Your interest rate: {Stavka}");
        }
        public string GenerationId()
        {
            
            _id = Name + Surname + _count;
            _count += 1;
            return _id;
        }
        public void Deposit()
        {

            Console.WriteLine("How much do you want to deposit");
            int value = int.Parse(Console.ReadLine());

            if (value < _minPut)
                Console.WriteLine($"Value less then minimum ({_minPut})");
            else
                Account += value;
        }
        public void Withdraw()
        {

            Console.WriteLine("How much do you want withdraw from the bill");
            int value = int.Parse(Console.ReadLine());

            if (value > _maxTake)
                Console.WriteLine($"Value is greater then maximum ({_maxTake})");

            if (Account > value)
            {
                Account -= value;
                
            }

            else
                Console.WriteLine("Insufficient funds on the bill");

            Console.WriteLine();
        }

        public static void StartBank()
        {
            Bank bank = new Bank();
                
            Console.WriteLine("Enter Name:");
            bank.Name = Console.ReadLine();

            Console.WriteLine("Enter Surname:");
            bank.Surname = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Enter the year of birth:");
            bank.Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the month of birth:");
            bank.Month = int.Parse(Console.ReadLine());

            int now = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            

            if (now - bank.Year >= 14 && month > bank.Month)
            {
                Console.WriteLine("Access is allowed");
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Choose actions with the bill \n 1 - To put money into the account \n 2 - Withdraw money from an account \n 3 - Find out information about account \n 4 - Rate change \n 5 - Buy");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            bank.Deposit();
                            break;

                        case 2:
                            bank.Withdraw();

                            break;

                        case 3:
                            bank.GetInform();
                            break;
                        case 4:
                            bank.NewRate();
                            break;
                        case 5:
                            Console.WriteLine("How many?");
                            int buy = int.Parse(Console.ReadLine());
                            bank.Buy(buy);
                            break;

                    }
                    Console.WriteLine("Want to repeat the operation selectin (Y/N)");
                    string a = Console.ReadLine();
                    if (a == "N" || a == "n") break;
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("You have not reached the required age");

            Console.WriteLine();
        }

        public static void CheckProfit()
        {
            Bank bank = new Bank();
            bank.Check += Message;
    
            bank.Deposit();
            bank.Buy(1000);
            bank.Buy(1000);
            Thread.Sleep(10000);
            bank.Instilled(DateTime.Now,2);

            void Message(string message)
            {
                Console.WriteLine(message);
                Console.WriteLine();
            }
        }

        
    }
}
