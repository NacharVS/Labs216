using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov
{
    class CalculationMetods
    { static public void QuadraticEquation(int a, int b, int c)
        {
            int D = (b * b) - (4 * a * c);
            int x1 = (-b + Convert.ToInt32(Math.Sqrt(D))) / (2 * a);
            int x2 = (-b - Convert.ToInt32(Math.Sqrt(D))) / (2 * a);
            Console.WriteLine($"X1= {x1} | X2= {x2}");
        }
        static public void PythagoreanTheorem(int a, int b)
        {
            int c = (a * a) + (b * b);
            Console.WriteLine($"Квадрат гиптенузы = {c * c}");
            
        }
        static public void Circumference(double radius)
        {
            double C = 2 * 3.14 * radius;
            Console.WriteLine($"Длина окружности равна: {C}");
        }
        static public void AreaCircle(double radius);
        
       







    }
}
