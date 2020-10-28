using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace Labs216.Khabibullina
{
    class bank
    {
        private string _id;
        private string _name;
        private string _surname;
        private static double _rate;
        private double _bankAccount;

        public void SetName(string newName)
        {
            newName = newName.Trim();
            var FirstLetter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = (FirstLetter.ToString().ToUpper() + otherLetters);
        }
        public void SetSurname(string newSurname)
        {
            newSurname = newSurname.Trim();
            var FirstLetter = newSurname[0];
            var otherLetters = newSurname.Remove(0, 1);
            _name = (FirstLetter.ToString().ToUpper() + otherLetters);
        }
        public bank(string name, string surname, double rate, string id, int bankAccount)
        {
            _name = name;
            _surname = surname;
            _rate = rate;
            _id = id;
            _bankAccount = bankAccount;
        }
        public static void Bank()
        {
            Console.WriteLine("Good afternoon, you are now on the main page of our service.");
            Console.WriteLine("Best deals for me: bla bla bla a lot of ads and useless offers");
            Console.WriteLine("Our rate is 10%");
        }

    }
}

