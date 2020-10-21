using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev
{
    class calculates
    {
        static public void QuadraticEquation(int x, int y, int z)
        {
            int D = (y * y) - (4 * x * z);
            int x1 = (-y + Convert.ToInt32(Math.Sqrt(D))) / (2 * x);
            int x2 = (-y - Convert.ToInt32(Math.Sqrt(D))) / (2 * x);
            Console.WriteLine($"x1= {x1} x2= {x2}");
        }
        static public void PiphagorTeroem(int a, int b)
        {
            double c = a * a + b * b;
            double c1 = Math.Sqrt(c);
            Console.WriteLine($"Гипотенуза С = {c1}");
        }
        static public void Circumference(int radius)
        {
            double C = 2 * Math.PI * radius;
            Console.WriteLine($"D круга=: {C}");
        }
        static public void AreaCircle(double radius)
        {
            double S = Math.PI * (radius * radius);
            Console.WriteLine($"s круга=: {S}");
        }
        static public void ParallepipedVolume(int a, int b, int c)
        {
            int V = a * b * c;
            Console.WriteLine($"Объём параллепипеда равен {V}");
        }
    }
}

