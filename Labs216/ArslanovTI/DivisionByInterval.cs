using System;
using System.Collections.Generic;
using System.Text;
//Создайте метод, который находит результат деления чисел из интервала чисел
namespace Labs216.ArslanovTI
{
    
    class DivisionByInterval
    {
        public static void ollo(string[] args)
        {
            Console.WriteLine("Введите число, на которое делить");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое число интервала");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число интервала");
            double c = int.Parse(Console.ReadLine());
            for (double i = b; i > c; i++)
            {
                double result = a / i;
                Console.WriteLine(result);
            }

        }


        }
    }
}
