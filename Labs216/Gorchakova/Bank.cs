using System;
namespace Labs216.Gorchakova
{
    abstract class Persian
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

    }
    class Sotrudnic : Persian
    {
        private string _Otdel;
        private int _Kabinet;

        public string Otdel
        {
            get => _Otdel;
            set => _Otdel = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
        }

        public int Kabinet
        {
            get => _Kabinet;
            set => _Kabinet = value;
        }

        public static void sotrudnic()
            {
            Sotrudnic sotrudnic = new Sotrudnic();

            Console.WriteLine("Enter Name:");
            sotrudnic.Name = Console.ReadLine();

            Console.WriteLine("Enter Surname:");
            sotrudnic.Surname = Console.ReadLine();

            Console.WriteLine("Enter Otdel:");
            sotrudnic.Otdel = Console.ReadLine();

            Console.WriteLine("Enter Kabinet:");
            sotrudnic.Kabinet = int.Parse(Console.ReadLine());
        }


    }
    class Bank : Persian
    { 
        private string _ID;
        private static int _stavka = 6;
        private int _account;
        private static int _minPut = 1000;
        private static int _maxTake = 10000000;
        private static int count = 0;

       

       public void GenerationID()
        {

            _ID = Name + Surname + count;
            count += 1;
        }

        public static void StartBank()
        {
            Bank bank = new Bank();

            Console.WriteLine("Enter Name:");
            bank.Name = Console.ReadLine();

            Console.WriteLine("Enter Surname:");
            bank.Surname = Console.ReadLine();

            bank.GenerationID();
            Console.WriteLine($"Your ID: {bank._ID}");

            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Choose actions with the bill \n 1 - To put money into the account \n 2 - Withdraw money from an account \n 3 - Calculate the amount of savings for several years ahead");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bank.Put();
                        break;

                    case 2:
                        bank.Take();
                        break;

                    case 3:
                        bank.Calculate();
                        break;

                }
                Console.WriteLine("Want to repeat the operation selectin (Y/N)");
                string a = Console.ReadLine();
                if (a == "N" || a == "n") break;

                Console.WriteLine();
            }
        }

        public void Put()
        {

            Console.WriteLine("How much do you want to deposit");
            int value = int.Parse(Console.ReadLine());

            if (value < _minPut)
                Console.WriteLine($"Value less then minimum ({_minPut})");
            else
                _account += value;

            Console.WriteLine($"On your account: {_account}");
            Console.WriteLine();
        }
        public void Take()
        {

            Console.WriteLine("How much do you want withdraw from the bill");
            int value = int.Parse(Console.ReadLine());

            if (value > _maxTake)
                Console.WriteLine($"Value is greater then maximum ({_maxTake})");

            if (_account > value)
                _account -= value;
            else
                Console.WriteLine("Insufficient funds on the bill");

            Console.WriteLine($"On your account: { _account}");
            Console.WriteLine();
        }

        public void Calculate()
        {
            if (_account == 0)
                Console.WriteLine("First you need to deposit money to your account");

            else
            {
                Console.WriteLine("How many years to calculate a Bank account");
                int year = int.Parse(Console.ReadLine());
                double calculate = 0;

                for (int i = 0; i < year; i++)
                {
                    calculate += ((_account + calculate) * _stavka) / 100;
                }

                Console.WriteLine($"Amount of savings in the account after {year} years: {calculate + _account}");
            }
            Console.WriteLine();
        }
    }   

}