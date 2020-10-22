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
        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetters;
        }
    }
}
