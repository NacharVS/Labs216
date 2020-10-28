using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Labs216.Anisimov
{
    abstract class Person
    {
        private string _name;
        private string _surname;
        private int _age;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != "")
                {
                    value = value.Trim();
                    _name = value[0].ToString().ToUpper() + value.Substring(1);
                }
                else _name = "defualt";
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value != "")
                {
                    value = value.Trim();
                    _surname = value[0].ToString().ToUpper() + value.Substring(1);
                }
                else _surname = "defualt";
            }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Фамилия: {Surname}");
            Console.WriteLine($"Возраст: {Age}");
        }
    }
    class BankEmployee : Person
    {
        private string _id;
        private static int _count = 0;
        private string _department;
        private string _experience;
        private int _pay;

        public int Departament
        {
            get { return _department; }
            set { _department = value; }
        }
        public int Experince
        {
            get { return _experience; }
            set { _experience = value; }
        }
        public int Pay
        {
            get { return _pay; }
            set { _pay = value; }
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Фамилия: {Surname}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Отдел: {Departament}");
            Console.WriteLine($"Опыт: {Experince}");
            Console.WriteLine($"Зарплата: {Pay}");
        }
    }
    class BankClient : Person
    {
        private string _id;
        private static double InterestRate = 5;
        private double _account;
        private static int _count = 0;
        private static int _Max = 100000;
        private static int _Min = 10000;
        private static int _MinAge = 14;
    }
}
