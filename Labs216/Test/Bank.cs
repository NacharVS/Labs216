using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Test
{
    class Bank
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate;
        private double _paymentAccount;
        private double _SetDateOffBirth;

        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetters;
        }
        public void SetFamilya(string newFam)
        {
            newFam = newFam.Trim();
            var FirstLetter = newFam[0];
            var otherLetters = newFam.Remove(0, 1);
            _surname = firstLetter.ToString().ToUpper + otherLetters;
        }
        public void SetID(string newID)
        {
            Random rnd = new Random();
            int _id = rnd.Next(100, 250);
        }
        private double chet;
        double _paymentaccount = Convert.ToDouble(Console.ReadLine());
    }
    public void SetDateOffBirth(int newDR)
    {
        int a = DateTime.Now.Millisecond;
        DateTime dayorbirth = DateTime.Now, Date;
    }
    public static void rabota()
    {
        Console.WriteLine("Выберите действие");
        Console.WriteLine("Пополнить счет - 1, Вывести - 2, Положить на депозит");
        int dei = Convert.ToInt32(Console.ReadLine());
        switch (dei)
        {
            case 1:
                Console.WriteLine("Вы выбрали снять со счета");
                Console.WriteLine("Введите сумму");
                double summa = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Баланс счета {chet}");
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
                Console.WriteLine("Выберите вкладываемую сумму");
                Console.WriteLine("Ключевая ставка в нашем банке - 0,4 в год");
                Double summ = Convert.ToDouble(Console.ReadLine());
                Double depoz = summ * 0.4;
                Console.WriteLine($"Через год вы получите {depoz}");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
    class bangrun
    {
        public static void run()
        }
        }
    


