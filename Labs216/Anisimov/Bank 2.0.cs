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

        public void GetAge()
        {
            Console.WriteLine("Write you birthday");
            Console.WriteLine("Day:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Mounth: (Example : may)");
            int month = 0;
            switch (Console.ReadLine())
            {
                case "январь":
                    month = 1;
                    break;
                case "февраль":
                    month = 2;
                    break;
                case "март":
                    month = 3;
                    break;
                case "апрель":
                    month = 4;
                    break;
                case "май":
                    month = 5;
                    break;
                case "июнь":
                    month = 6;
                    break;
                case "июль":
                    month = 7;
                    break;
                case "август":
                    month = 8;
                    break;
                case "сентябрь":
                    month = 9;
                    break;
                case "октябрь":
                    month = 10;
                    break;
                case "ноябрь":
                    month = 11;
                    break;
                case "декабрь":
                    month = 12;
                    break;
            }
            Console.WriteLine("Year:");
            int year = int.Parse(Console.ReadLine());
            year = DateTime.Now.Year - year - 1;
            {
                if (DateTime.Now.Month >= month & DateTime.Now.Day >= day) Age = year + 1;
                else Age = year;
            }
        }

        public virtual void GetInfo()
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

        public string Departament
        {
            get => _department;
            set { _department = value; }
        }
        public string Experince
        {
            get { return _experience; }
            set { _experience = value; }
        }
        public int Pay
        {
            get { return _pay; }
            set { _pay = value; }
        }
        public string Id
        {
            get { return _id; }
        }

        private void GenId()
        {
            _id = Name + Surname + "_" + _count;
            _count = _count + 1;
        }

        public BankEmployee (string name, string surname, string department, string experience, int pay)
        {
            Name = name;
            Surname = surname;
            Departament = department;
            Experince = experience;
            Pay = pay;
            GenId();
            GetAge();
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

        public string Id
        {
            get { return _id; }
        }
        public double Account
        {
            get { return _account; }
            set { _account = value; }
        }
        public static int Count
        {
            get { return _count; }
        }
        private void GenId()
        {
            _id = Name + Surname + "_" + _count;
            _count = _count + 1;
        }


        public override void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Фамилия: {Surname}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Счет: {Account}");
            Console.WriteLine($"Ставка: {InterestRate}");
        }
    }

   
}
