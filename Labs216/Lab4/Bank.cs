using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Lab4
{
    class Bank
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _stavka = 6.7;
        private double _score;
        private int _age;
        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetters;
        }
        public void SetSurname(string newSurname)
        {
            newSurname = newSurname.Trim();
            var firstLetter = newSurname[0];
            var otherLetters = newSurname.Remove(0, 1);
            _surname = firstLetter.ToString().ToUpper() + otherLetters;
        }
        public static void Bank1()
        {
            Console.WriteLine("Welcome to our bank!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Withdraw money");
            Console.WriteLine("2. Deposit money");
            string a = Console.ReadLine();
            double max = 200000;
            double min = 10000;
            switch (a)
            {
                case "1":
                    Console.WriteLine("Can be removed max 200 000!");
                    int value = int.Parse(Console.ReadLine());
                    if (value < max)
                        Console.WriteLine("The operation was successful!");
                    else
                        Console.WriteLine("Mistake!");
                    break;
                case "2":
                    Console.WriteLine("Can be removed min 10 000");
                    int value1 = int.Parse(Console.ReadLine());
                    if (value1 > min)
                        Console.WriteLine("The operation was successful!");
                    else
                        Console.WriteLine("Mistake!");
                    break;
            }
        }
        public static void SetStavka()
        {
            double _score = 17000;
            double _stavka = 6.7;
            Console.WriteLine($"Stavka in our bank - {_stavka}%");
            Console.WriteLine($"our score {_score}");
            Console.WriteLine("How many years would you like to withdraw money?");
            double years = double.Parse(Console.ReadLine());
            double i = 0;
            for ( i = 0; i < years; i++)
            {
                i = ((100 * _score) / _stavka) * 100;
            }
            Console.WriteLine($"Your account will have {i} in {years} years");
        }
        public void SetAge()
        {
            int p = DateTime.Now.Millisecond;
            int result = 0;
            DateTime age = DateTime.Now.Date;
            result = p - DateTime.Now.Month;
            Console.WriteLine(result);
        }

    }
}
