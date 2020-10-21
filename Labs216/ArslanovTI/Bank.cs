using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI
{
    class Bank
    { private string _name;
        private string _id;
        private static double _rate;
        private double sum;
     
    }
        public static void Banks(string[] args)
            
        
        {
            
            Console.WriteLine("Введите ФИО");
            string name = Console.ReadLine();
            Random rnd = new Random();
            int id = rnd.Next(99999, 100000);
            Console.WriteLine($"{name}Вашему счету присвоен id{id}");
            int end = 1;
            while (end == 1) { 

            Console.WriteLine("Какую операцию вы хотите произвести");
            Console.WriteLine("Нажмите 1 - Пополнить счет");
           Console.WriteLine("Нажмите 2 - Вывести со счета");
            int sum = 0;
            int vibor = int.Parse(Console.ReadLine());
            if (vibor == 1)
            {
                Console.WriteLine("Введите сумму, которую вы хотите положить на счет");
                int popoln = int.Parse(Console.ReadLine());
                sum = popoln + sum;
            }

            if (vibor == 2) 
            {
                Console.WriteLine("Введите сумму, которую вы хотите cнять со счета");
                int snyat = int.Parse(Console.ReadLine());
                if (snyat > sum) 
                {
                    Console.WriteLine("Недостаточно средств на счете");
                }
                sum = sum - snyat;
                    Console.Writeline("Закрыть программу");

            }
               













            }
    }
}
