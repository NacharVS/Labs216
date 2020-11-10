using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Faskhutdinov
{
    class Bank
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate;
        private double _paymentAccount;

        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetter = newName.Remove(0, 1);
            _name = (firstLetter.ToString().ToUpper() + otherLetter);
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
            Console.WriteLine("Добро пожаловать в банк");
            Console.WriteLine("Ставка банка - 7,3");
            Console.WriteLine("Введите свои данные");
            string name, surname = Console.ReadLine();

        }

    }
}
