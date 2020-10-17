using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Stepanov
{
    class CalculationMethods
    {
        static public void QuadraticEquation(int a, int b, int c)
        {
            int D = (b * b) - (4 * a * c);
            int x1 = (-b + Convert.ToInt32(Math.Sqrt(D))) / (2 * a);
            int x2 = (-b - Convert.ToInt32(Math.Sqrt(D))) / (2 * a);
            Console.WriteLine($"X1 = {x1}| X2 = {x2}");
        }

        static public void PythagoreanTheorem(int a, int b)
        {
            int c = (a * a) + (b * b);
            Console.WriteLine($"Квадрат гипотенузы = {c * c}");
        }

        static public void Circumference(double radius)
        {
            double C = 2 * 3.14 * radius;
            Console.WriteLine($"Длина окружности равна: {C}");
        }

        static public void AreaCircle(double radius)
        {
            double S = 3.14 * (radius * radius);
            Console.WriteLine($"Плащадь окружности равна: {S}");
        }

        static public void ParallepipedVolume(int a, int b, int c)
        {
            double V = a * b * c;
            Console.WriteLine($"Объем параллелепипеда равен: {V}");
        }

        static public void Amperage(int U, int R)
        {
            double I = U / R;
            Console.WriteLine($"Сила тока = {I}");
        }
        static public void Resistance(int U, int I)
        {
            double R = U / I;
            Console.WriteLine($"Сопротивление = {R}");
        }

        static public void Voultage(int I, int R)
        {
            double U = I * R;
            Console.WriteLine($"Напряжение = {U}");
        }


    }
}