using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev
{
    class Bank
    {
        public static void bankomat()
        {
            Bank acc1 = new Bank();
            Console.WriteLine("What do you want: 1 -- вывести деньги || 2 -- вложить деньги || 3 -- проверка счета  || 4 -- расчитать депозит");
        }
        private string _name;
        private string _surname;
        private string _id;
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
        public string id
        {
            get { return _id; }
        }
        public string accound
        {
            get { return accound; }
            set { accound = value; }
        }
        public Bank()
        {
            Console.WriteLine("введите имя");
            _name = Console.ReadLine();
            Console.WriteLine("введите фамилию");
            _surname = Console.ReadLine();
            _id = _name + _surname ;
            
            Console.WriteLine($"здраствуйте, {_name} {_surname}, ваш id  {_id} у вас  {_account} то есть вы бомж ");
        }
    }
}
    
    
