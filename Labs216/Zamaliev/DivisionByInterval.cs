using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zamaliev
{
    class DivisionByInterval
    {
        public static void Division()
        {
            Console.WriteLine("введите число,которое хотите поделить на интервал чисел");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите начало интервала");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите конец интервала");
            double s = Convert.ToDouble(Console.ReadLine());
            for (double b = a; b <= s; b = b + 1)
            {
                double y = x / b;
                Console.WriteLine($"когда делишь {x} на {b} ответ:" + y);
            }
        }
    }
}
