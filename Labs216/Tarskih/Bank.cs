﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih
{
    class Bank
    {
        private string _name;
        private string _surname;
        private int _age;
        private static double _rate;
        private double _account;

        public Bank(string name, string surname, int refund, double rate, string id, double account)
        {
            _name = name;
            _surname = surname;
            _age = refund;
            _rate = rate;
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
        public void SetAge()
        {
            int x = DateTime.Today.Year;
            _age = x - _age;
            Console.WriteLine($"Ваш возраст {_age}");
        }
        public void SetAccount()
        {
            Console.WriteLine($"На счёте сейчас {_account} валюты");
            Console.WriteLine(" 1. Снять со счёта \n 2. Положить на счёт");
            string b = Console.ReadLine();
            switch (b)
            {
                case "1":
                    Console.WriteLine("Максимум - 200000 валюты");
                    double with = double.Parse(Console.ReadLine());
                    if (_account > with)
                    {
                        if (with > 200000)
                        {
                            Console.WriteLine("Ошибка");
                        }    
                        else
                        {
                            Console.WriteLine($"На вашем счёте: {_account -= with} средств");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"На вашем счёте {_account} money");
                    }
                    break;
                case "2":
                    Console.WriteLine("Минимальная сумма - 50 валюты");
                    double put = double.Parse(Console.ReadLine());
                    if (put < 50)
                    {
                        Console.WriteLine("Ошибка");
                    }
                    else
                    {
                        Console.WriteLine($"На вашем счёте {_account += put} валюты");
                    }
                    break;
            }
        }
        public void SetRate()
        {
            _account = 7.7;
            Console.WriteLine($"Ставка = {_rate}");
            Console.Write("После скольки лет вы хотите снять деньги?");
            double year = double.Parse(Console.ReadLine());
            double y = _account * (Math.Pow(_rate, year));
            Console.WriteLine($"После {y} лет, на вашем счёте будет {_account} валюты");            
        }
    }
}