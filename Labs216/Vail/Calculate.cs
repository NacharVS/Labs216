using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Vail
{
    class Calculate
    {
        static public void QuadraticEquation(int a, int b, int c)
        {
            int d = (b * b) - (4 * a * c);
            int A1 = (-b + Convert.ToInt32(Math.Sqrt(d))) / (2 * a);
            int A2 = (-b - Convert.ToInt32(Math.Sqrt(d))) / (2 * a);
            Console.WriteLine($"A1 = {A1} | A2 = { A2}");
        }
        static public void PythagoreanTheorem(int a, int b)
        {
            int c = (a * a) + (b * b);
            Console.WriteLine($"квадрат гипотенузы = {c * c}");
        }

        static public void CircumFerence(int R)
        {
            double e = 2 * Math.PI * R;
            Console.WriteLine($"Длина Окружности = {e}");
        }
        static public void AreaCircle(double radius)
        {
            double S = 3.14 * (radius * radius);
            Console.WriteLine($"площадь окружности = {S}");
        }
        static public void ParallelepipedVolume(int f, int g, int h)
        {
            double V = f * g * h;
            Console.WriteLine($"объем параллелепипела = {V}");
        }
        static public void Amperage(int U, int R)
        {
        double I = U / R;
        Console.WriteLine($"сила тока = {I}");
        }
        static public void Voultage(int I, int U)
        {
        double R = U / I;
        Console.WriteLine($"напряжение = {R}");
        }
        static public void Resistanse(int I, int R)
        {
        double U = I * R;
        Console.WriteLine($"сопротивление = {U}");
        }
    }
}
