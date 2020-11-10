using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov
{
    class Bank
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate;
        private double _paymentAccount;

        public Bank(string name, string surname, int vozrast, double stavka, string id, double schet)
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
            newName = newName.Trim;
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
        public void SetVozrast ()
        {
            int a = DateTime.Today.Year;
            _vozrast = a - _vozrast;
            Console.WriteLine($"Возраст: {_vozrast}");
        }
        public void SetSchet ()
        {
            Console.WriteLine($"Сейчас на счету: {_schet}");
            Console.WriteLine(" 1. Снять деньги \n 2. Положить деньги");
            string b = Console.ReadLine();
            switch (b)
            {
                case "1":
                    Console.WriteLine("Max 150000");
                    double with = double.Parse(Console.ReadLine());
                    if (_schet > with)
                    {
                        if (with > 150000)
                        {
                            Console.WriteLine("Нет!");
                        }
                        else
                        {
                            Console.WriteLine($"На вашем счете: {_schet -= with} money");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"На вашем счете: {_schet")
                    }
            }
        }
        }
    }
}
