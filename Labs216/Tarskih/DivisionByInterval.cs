using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih
{
    class DivisionByInterval
    {
        public static void DivisionbyInterval()
        {
            Console.WriteLine("Введите число");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите начало интервала");
            double f = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите конец интервала");
            double s = double.Parse(Console.ReadLine());

            for (double a = f; a <= s; a++)
            {
                double devision = n / a;
                Console.WriteLine($"Результат деления {n} на {a} = {devision}");
            }
        }
    }
}
