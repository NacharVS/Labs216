using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov
{
    abstract class Person
    {
        private string _name;
        private string _surname;

        public string Name
        {
            get => _name;
            set => _name = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
        }

        public string Surname
        {
            get => _surname;
            set => _surname = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
        }

        public virtual void GetInform()
        {
            Console.WriteLine($"Your name: {Name}{Surname}");
        }

        class Clerk : Person
        {
            private static int _departament;

            public override void GetInform()
            {
                Console.WriteLine($"Ваше имя: {Name}{Surname}");
                Console.WriteLine($"Ваш департамент: {_departament}");
                _departament += 1;

            }
        }

        class Bank : Person
        {
            public delegate void ChangeRate(double rate);

            public event ChangeRate Notify = (double rate) => Console.WriteLine($"Новая ставка{rate}");

            public delegate void OnAccount(string message);

            public event OnAccount Check = (string message) => Console.WriteLine(message);

            private static DateTime _account
         }

    }
