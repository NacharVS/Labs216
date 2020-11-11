using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev
{
    class ban4ik
    {
        public static void bankomat()
        {
            bankomat acc1 = new bankomat();
            Console.WriteLine("What do you want: 1 -- вывести деньги || 2 -- вложить деньги ");
        }
        private string _name;
        private string _surname;
        private int _balanse;
        private static int stavka = 9;
        private double _account;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public int balanse
        {
            get { return _balanse; }
            set { _balanse = value; }
        }
        private static void registration()
        {
            Console.WriteLine("введите имя ");
            string name = Console.ReadLine();
            Console.WriteLine("введите фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("аккаунт создан,пользуйтесь на здоровье");
            Console.WriteLine($"ваш счет{_balanse} p.");
        }
    }
}
