using System;

namespace Labs216
{
    class DivisionByIntrval
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Введите число");
          double a = double.Parse(Console.ReadLine());
          Console.WriteLine("Введите длину интервала");
          double b = double.Parse(Console.ReadLine());
          Console.WriteLine("Введите конечное число интервала");
          double c = double.Parse(Console.ReadLine());
            for (double x = b; x <= c; x++);
            {
                if (x != 0)
                {
                    double y = a / x;
                    Console.WriteLine("$ (a / x = y)");
                }
            }    
        }
    }
}
