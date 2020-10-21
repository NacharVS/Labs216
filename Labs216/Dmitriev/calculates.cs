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
            Console.WriteLine($"x1={x1} x2={x2}");
        }
    }
}

