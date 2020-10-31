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
        private static void addition()
        {
            Console.WriteLine("vediti summu popolnenya no ");
            int a = 0;
            if (a <= 10000 | a >= 20000)
            {
                while (a <= 10000 | a >= 20000)
                {
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("рассчет пополнения от 10000 до 20000");
                        Console.Write("введите сумму пополнения");
                        a = int.Parse(Console.ReadLine());
                    }
                }
            }
            balanse += a;
            Console.WriteLine($"ваш счет { balance} p.");
        }
        private static void cut()
        {
            Console.WriteLine("введите которую хотитие вывести ");
            int a = int.Parse(Console.ReadLine());
            while (balans - a < 0)
            {


                try
                {
                    int a = int.Parse(Console.ReadLine());
                }

                catch
                {
                    if (a <= 10000 | a >= 20000)
                    {
                        Console.WriteLine($"нет бабок");
                        Console.Write("введите сумму которую хотите снять");
                        a = int.Parse(Console.ReadLine());
                    }
                }
                balans -= a;
                Console.WriteLine("деньги сняты ");
                Console.WriteLine($"ваш счет { balance} p.");
            }
            public static void run()
            {
                while (true)
                {
                    Console.WriteLine("создание аккаунта(1)");
                    Console.WriteLine("gполнение счета (2)");
                    Console.WriteLine("снять с счета(3)");
                    switch (a)
                    {
                      case 1: registration();break;
                        case 2: addition(); break;
                        case 3: cut(); break;



                    }
                }

            }
        }
    }
}


             
            




        
    


    
    
