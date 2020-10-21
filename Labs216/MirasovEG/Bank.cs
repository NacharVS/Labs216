using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Labs216.MirasovEG
{
    class Bank
    {
        private string _name;
        private string _ID;
        private string _surname;
        private static int stavka = 6;
        private int _bill;
        private static int _minPut = 1000;
        private static int _maxTake = 100000;
        private static int count = 0;

        public string Name
        {
            get => _name;
            set => _name = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
        }
    
        public string Surname
        {
            get => _surname;
            set =>_surname = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
        }

        public void GenerationID()
        {
            Bank bank = new Bank();
            bank._ID = bank.Name + bank.Surname + Bank.count;
            Bank.count += 1;
        }

        public static void StartBank()
        {
            Bank bank = new Bank();

                Console.WriteLine("Enter Name:");
                bank.Name = Console.ReadLine();

                Console.WriteLine("Enter Surname:");
                bank.Surname = Console.ReadLine();

                bank.GenerationID();

            while (true)
            {
                Console.WriteLine("Choose actions with the bill (1 - To put money into the account || 2 - Withdraw money from an account )");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Put();
                        break;

                    case 2:
                        Take();
                        break;

                }
                Console.WriteLine("Want to repeat the operation selectin (Y/N)");
                string a = Console.ReadLine();
                if (a == "N") break;

                Console.WriteLine("Want to know the account size (Y/N)");
                string b = Console.ReadLine();
                if (b == "Y")
                    Console.WriteLine(bank._bill);
            }
            

                
        }

        public static void Put()
        {
            Bank bank = new Bank();
            Console.WriteLine("How much do you want to deposit");
            int value = int.Parse(Console.ReadLine());
            if(value < Bank._minPut)
                Console.WriteLine($"Value less then minimum ({Bank._minPut})");
            else
            bank._bill += value; 
        }
        public static void Take()
        {
            Bank bank = new Bank();
            Console.WriteLine("How much do you want withdraw from the bill");
            int value = int.Parse(Console.ReadLine());
            if (value > Bank._maxTake)
                Console.WriteLine($"Value is greater then maximum ({Bank._maxTake})");

            if (bank._bill > value)
                bank._bill -= value;
            else
                Console.WriteLine("Insufficient funds on the bill");

        }

    }
}
