using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Labs216.GaraevaAF
{
    class Exercise2
    {
       static public void Exercise21()
        {
            Console.WriteLine("Enter the first number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Solve the given equation {a}x*x+{b}x+{c}=0");
            double D = 0;
            {
                if (D > 0)
                {
                    D = b * b - 4 * a * c;
                    Console.WriteLine($"1) D = {b}*{b} - 4*{a}*{c} ");
                    Console.WriteLine($"D = {D}");
                    double x1 = 0;
                    x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine($"2) x1 = {-b} + {Math.Sqrt(D)} / 2*{a}");
                    Console.WriteLine($"x1 = {x1}");
                    double x2 = 0;
                    x2 = ((-b) - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine($"3) x2 = {-b} + {Math.Sqrt(D)} / 2*{a}");
                    Console.WriteLine($"x2 = {x2}");
                }
                if (D == 0)
                {
                    double x = 0;
                    x = -b / (2 * a);
                    Console.WriteLine($" x = -{b} / (2*{a})");
                    Console.WriteLine($"x = {x}");
                }
                if (D < 0)
                {
                    Console.WriteLine("There is no decision");
                }
            }
        }
    }
}
