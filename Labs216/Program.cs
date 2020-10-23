using System;

namespace Labs216
{
    class DivisionByIntrval
    {
        static public void Main(string[] args)
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
                Console.WriteLine($"{a} / {f} --{a / f};
            }
        }
    }
}
