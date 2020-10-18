using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih
{
    class DivisionByInterval
    {
        public static void DivisionbyInterval()
        {
            Console.WriteLine("Введите число");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите начало интервала");
            double f = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите конец интервала");
            double s = double.Parse(Console.ReadLine());

            for (double a = f; a <= s; a++)
            {
                double division = n / a;
                Console.WriteLine($"Результат деления {n} на {a} = {division}");
            }
        }
        public static void KvadrantoyeUranveniye(int a, int b, int c)
        {
            int d = b * b + 4 * a * c;
            int d1 = (int)(Math.Sqrt(d));
            int x1 = (-b + d1) / (a * 2);
            int x2 = (-b - d1) / (a * 2);
            Console.WriteLine($"X1 = {x1} X2 = {x2}");
        }
        public static void TeoremaPifagora(int a, int b)
        {
            int c = a * a + b * b;
            double c1 = Math.Sqrt(c);
            Console.WriteLine($"Гипотенуза = {c1}");
        }
        public static void DlinaOkruzhnisti(int R)
        {
            double P = 2 * R;
            Console.WriteLine($"Периметр = {P}п");
        }
        public static void PloshadOkruzhntosti(int R)
        {
            double S = R * R;
            Console.WriteLine($"Площадь = {S}п");
        }
        public static void ObyemParallelepiped(int a, int b, int c)
        {
            int V = a * b * c;
            Console.WriteLine($"Объём параллелепипеда = {V}");
        }
        public static void Amperage(int R, int U)
        {
            int I = U / R;
            Console.WriteLine($"Сила Тока = {I}");
        }
        public static void Resistance(int I, int U)
        {
            int R = U / I;
            Console.WriteLine($"Сопротивление = {R}");
        }
        public static void Voltage(int I, int R)
        {
            int U = R * I;
            Console.WriteLine($"Напряжение = {U}");
        }
    }
}
