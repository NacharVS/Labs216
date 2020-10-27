using System;
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
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate;
        private double _paymentAccount;
        private int _SetDATAROZHDENIYA;
        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetters;
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
        private double chet;
        double _paymentaccount = Convert.ToDouble(Console.ReadLine());
    }
    public void SetDenRozhd(int newDR)
    {
        int a = DateTime.Now.Millisecond;
        DateTime dayofbirth = DateTime.Now.Date;
    }

    class bangrun
    {
        public static void run()
        {
        }
    }
}
