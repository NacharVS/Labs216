using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina
{
    class BANK
    {
        private string _name;
        private string _surname;
        private int _vozrast;
        private static double _stavka;
        private string _id;
        private double _schet;

        public BANK(string name, string surname, int vozrast, double stavka, string id, double schet)
        {
            _name = name;
            _surname = surname;
            _vozrast = vozrast;
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
        public void SetVozrast()
        {
            int a = DateTime.Today.Year;
            _vozrast = a - _vozrast ;
            Console.WriteLine($"Age: {_vozrast}");
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
                    double with = double.Parse (Console.ReadLine());
                    if (_schet > with)
                    {
                        if (with > 200000)
                        {
                            Console.WriteLine("NOOOT!!!");
                        }
                        else
                        {
                            Console.WriteLine($"On your account: {_schet -= with} money");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"On your account: {_schet} money");
                    }
                    break;
                case "2":
                    Console.WriteLine("Min 50");
                    double put = double.Parse(Console.ReadLine());
                    if (put < 50)
                    {
                        Console.WriteLine("NOOOT!!!");
                    }
                    else
                    {
                        
                        Console.WriteLine($"On your account: { _schet += put } monney");
                    }
                    break;
            }


        }
        public void SetStavka ()
        {
            _stavka = 6.7;
            Console.WriteLine($" Stavka  = {_stavka} ");
            Console.Write(" After how many years do you withdraw money? ");
            double let = double.Parse (Console.ReadLine());
            double c;
            for (int i=0; i < let; i++)
            {
                 _schet += _schet / 100 * _stavka;
                
            }
            Console.WriteLine($"After {let} years, your account will have an {_schet} amount "); 
            
        }
        public void SetId (int NewSetId)
        {

        }
    
    
    }
}
