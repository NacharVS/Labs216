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
        public static void KvadrantoyeUranveniye(int a, int b, int c)
        {
            int d = b * b + 4 * a * c;
            int d1 = (int)(Math.Sqrt(d));
            int x1 = (-b + d1) / (a * 2);
            int x2 = (-b - d1) / (a * 2);
            Console.WriteLine($"X1 = {x1} X2 = {x2}");
        }
    }
}
