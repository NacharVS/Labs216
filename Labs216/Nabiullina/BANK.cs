using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina
{
    class BANK
    {
        private string _name;
        private string _surname;
        private static double _stavka;
        private string _id;
        private int _schet;

        public BANK(string name, string surname, double stavka, string id, int schet)
        {
            _name = name;
            _surname = surname;
            _stavka = stavka;
            _id = id;
            _schet = schet;

        }
         public void SetName(string newName)
         {
           newName = newName.Trim();
           var firstLetter = newName[0];
           var otherLetters = newName.Remove(0, 1);
           _name = firstLetter.ToString().ToUpper() + otherLetters;
         }
        public void SetSurame(string newSurname)
        {
            newSurname = newSurname.Trim();
            var firstLetter = newSurname[0];
            var otherLetters = newSurname.Remove(0, 1);
            _surname = firstLetter.ToString().ToUpper() + otherLetters;
        }
        public void SetStavka (double newStavka)
        {
            Console.WriteLine(" Stavka  = 6,7% ");
            Console.WriteLine(" How much money is in the account? ");
            double a = double.Parse (Console.ReadLine());
            Console.Write(" After how many years do you withdraw money? ");
            double let = double.Parse (Console.ReadLine());
            double st = 6.7;
            double c = a * (Math.Pow(st, let));
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

    }
}
