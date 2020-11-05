using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih
{
    class Bank
    {
        private string _name;
        private string _surname;
        private int _refund;
        private static double _rate;
        private string _id;
        private double _account;

        public Bank(string name, string surname, int refund, double rate, string id, double account)
        {
            _name = name;
            _surname = surname;
            _refund = refund;
            _rate = rate;
            _id = id;
            _account = account;
        }
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
        public void SetAccount()
        {
            Console.WriteLine($"На счёте сейчас {_account} валюты");
            Console.WriteLine(" 1 - Снять со счёта  2 - Положить на счёт");
            string b = Console.ReadLine();
        }

    }
}
