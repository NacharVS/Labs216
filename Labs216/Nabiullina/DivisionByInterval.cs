using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina
{
    class DivisionByInterval
    {
        static public void DivisionByInterval1()
        {
            Console.WriteLine("Enter a namber:");
            double a = double.Parse (Console.ReadLine());

            Console.WriteLine("Division from what namber?");
            double x = double.Parse (Console.ReadLine());

            Console.WriteLine("Division from what namber?");
            double y = double.Parse (Console.ReadLine());
            for (double b = x; b <= y; b++ )
            {
                if (b != 0)
                {
                    double z = a / b;
                    Console.WriteLine($"{a} divided by {b} = {z}");
                }
            }
        }
        
        static public void DivisionByInterval2()
        {
            Console.WriteLine(" The solution to ax^2-bx+c");
            Console.Write("a = ");
            int a = int.Parse (Console.ReadLine());
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($" Answer: {a}*{x}^2-{b}*{x}+{c}={a * Math.Pow(x, 2) - b * x + c}");
        }

    }

}
