using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Vail
{
    class Calculate
    {
        static public viod KvadratniyCalculator(int a, int b, int c)
        {
            int d = (b * b) - (4 * a * c);
            int A1 = (-b + Convert.ToInt32(Math.Sqrt(d))) / (2 * a);
            int A2 = (-b - Convert.ToInt32(Math.Sqrt(d))) / (2 * a);
            Console.WriteLine($"A1 = {A1} | A2 = { A2}");
        }
    }
}
