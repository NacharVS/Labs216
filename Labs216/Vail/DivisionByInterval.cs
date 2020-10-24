using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Vail
{
    class DivisionByInterval
    {
        static public void Run()
        {
            Console.WriteLine("Введите любое число");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое число интервала");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите последнее число интервала");
            double last = double.Parse(Console.ReadLine());
            for (double f = first; f <= last; f++)
            {
                if (f == 0) continue;
                Console.WriteLine($"{a} / {f} --{a / f}");
            }
        }
    }
}
