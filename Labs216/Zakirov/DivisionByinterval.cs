using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov
{
    class DivisionByinterval

    {
        static public void Division()
        {
            Console.WriteLine("Введите число, которое будете делить");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите начальный интервал");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечный интервал");
            double second = double.Parse(Console.ReadLine());
            for (double i = first; i<= second; i++)
            {
                if (i == 0) continue;
                double division = number / i;
                Console.WriteLine($"Результат деления {number} на {i} = {division}");

            }

        }

    }
}
