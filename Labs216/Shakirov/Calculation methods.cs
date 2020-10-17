using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov
{
    class Calculation_methods
    {
        static public void QuadraticEquation(int a, int b, int c)
        {
            int D = (b * b) - (4 * a * c);
            int y1 = (-b + Convert.ToInt32(Math.Sqrt(D))) / (2 * a);
            int y2 = (-b - Convert.ToInt32(Math.Sqrt(D))) / (2 * a);
            Console.WriteLine($"Y1 = {y1}| Y2 = {y2}");
        }

        static public void PythagoreanTheorem(int a, int b)
        {
            int c = (a * b) + (b * b);
            Console.WriteLine($"Квадрат гипотенузы = {c * c}");
        }


    }
}
