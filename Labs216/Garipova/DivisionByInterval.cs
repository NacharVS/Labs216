using System;


namespace Labs216.Garipova216
{
    class DivisionByInterval

    {
        static public void DivisionByInterval1()
        {
            Console.WriteLine("Enter a number-");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Division from what number-");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Division from what number-");
            double c = double.Parse(Console.ReadLine());
            for (double d = b; d <= c; d++)
            {
                if (d != 0)
                {
                    double x = a / d;
                    Console.WriteLine($"{a} divided by {d} = {x}");
                }   
            }
        }
    }
}
