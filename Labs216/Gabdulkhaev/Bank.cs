﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev
{
    class bank
    {
        // Имя Фамилия\
        // ID клиента
        // Процент
        // Кол-во денег на счету
        // сгенерировать
        public delegate void prikol(string message);
        public event prikol SMS;
        private string _name;
        private int _number;
        private string _surname;
        private string _id;
        private static double _rate;
        private double _paymentAccount;
        private int _SetDATAROZHDENIYA;
        public string SetName
        {
            get { return _name; }
            set
            {
                _name = value;
            }
    }
        public string _Name { get; private set; }
        public void Smena(int _name)
        {
            _Name += _name;
            SMS?.Invoke($"Имя сменили на: {_name}");
        }
        public void Setnumb(int newNumb)
        {
            newNumb = Convert.ToInt32(Console.ReadLine());
        }
        public void SetFamiliya(string newFam)
        {
            newFam = newFam.Trim();
            var firstLetter = newFam[0];
            var otherLetters = newFam.Remove(0, 1);
            _surname = firstLetter.ToString().ToUpper() + otherLetters;
        }
        public void SetID(string newID)
        {
            Random rnd = new Random();
            int _id = rnd.Next(100, 250);
        }
        public double chet;
        double _paymentaccount = Convert.ToDouble(Console.ReadLine());
    }
}
    public void SetDenRozhd(int newDR)
    {
        int a = DateTime.Now.Millisecond;
        DateTime dayofbirth = DateTime.Now.Date;
    }
    public static void rabota()
    {
        Console.WriteLine("Выберите действие");
        Console.WriteLine("Положить на счет - 1, снять - 2, положить на депозит 3");
        int dei = Convert.ToInt32(Console.ReadLine());
        switch (dei)
        {
            case 1:
                Console.WriteLine("Вы выбрали снять со счета");
                Console.WriteLine("Введите сумму");
                double summa = Convert.ToDouble(Console.ReadLine());
                double chet = _paymentaccount - summa;
                Console.WriteLine($"Итоговый счет {chet}");
                break;
            case 2:
                Console.WriteLine("Вы выбрали положить на счет");
                Console.WriteLine("Введите сумму");
                    double raznost = Convert.ToDouble(Console.ReadLine());
                chet = _paymentaccount - raznost;
                Console.WriteLine($"Итоговый счет {chet}");
                break;
            case 3:
                Console.WriteLine("Вы выбрали депозит");
                Console.WriteLine("Выберите какую сумму хотите положить");
                Console.WriteLine("Процент в нашем банке - 0,3859195 в год");
                double summmmmmmmmmmmm = Convert.ToDouble(Console.ReadLine());
                double depoz=summmmmmmmmmmmm*0.3859195;
                Console.WriteLine($"Через год вы получит {depoz}");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
    // Надо добавить эвенты
    // Сделать касхбацк
    // profit

    class bangrun
    {
        public static void run()
        {
        }
    }
