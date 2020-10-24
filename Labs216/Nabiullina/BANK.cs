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
        public void SetSchet ()
        {
            
            Console.WriteLine($"On the account now: {_schet}");
            Console.WriteLine(" 1. Withdraw money  \n 2. Put money");
            string b = Console.ReadLine();
            switch (b)
            {
                case "1":
                    Console.WriteLine("Max 200000");
                    int with = int.Parse (Console.ReadLine());
                    if (_schet > with)
                    {
                        if (with > 200000)
                        {
                            Console.WriteLine("NOOOT!!!");
                        }
                        else
                        {
                            Console.WriteLine(_schet - with);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"On your account : {_schet}");
                    }
                    break;
                case "2":
                    Console.WriteLine("Min 50");
                    int put = int.Parse(Console.ReadLine());
                    if (put < 50)
                    {
                        Console.WriteLine("NOOOT!!!");
                    }
                    else
                    {
                        _schet += put;
                        Console.WriteLine(_schet );
                    }
                    break;
            }


        }
        public void SetStavka ()
        {
            Console.WriteLine($" Stavka  = {_stavka} ");
            Console.Write(" After how many years do you withdraw money? ");
            double let = double.Parse (Console.ReadLine());
            double c = _schet * (Math.Pow(_stavka, let));
            Console.WriteLine($"After {let} years, your account will have an {c} amount "); 
            
        }

    }
}
