using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Topunova
{
    class Bank
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate;
        private double _paymentAccount;

        public void ClientInfo()
        {
            Console.WriteLine("Введите: {_name}, {_surname}");
            Console.WriteLine("Введите: {_id}");
            Console.WriteLine("const = _rate");
        }
        public void SetName(string newName)
        {
            _name = newName.Trim();
            var firstLetter = newName[0];
            var otherLetter = newName.Remove(0, 1);
            _name = (firstLetter.ToString().ToUpper() + otherLetter);
        }
        public void Setsurname(string newsurname)
        {
            newsurname = newsurname.Trim();
            var firstLatter = newsurname[0];
            var otherLatter = newsurname(0, 1);
            newsurname = (firstLatter.ToString().ToUpper() + otherLatter);
        }
        public void SetId(string newId)
        {
            newId = newId.Trim();
            var firstLatter = newId[0];
            var otherLatter = newId(0, 1);
            newId = (firstLatter.ToString().ToUpper() + otherLatter);
        }
        public static void Go()
        {
            Bank bank = new Bank();
            Console.WriteLine("Введите: ");
            bank._name = Console.ReadLine();
            Console.WriteLine();
            bank._surname = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Введите: ");
            double month = double.Parse(Console.WriteLine());
            double month = double.Parse(Console.ReadLine())
            Console.WriteLine("Введите: ");
            double year = double.Parse(Console.WriteLine());
            double year = double.Parse(Console.ReadLine());

            double now = DateTime.Now.Year;
            double mounth = DateTime.Now.Month;

            if (now - year  )
        }
    }
}

