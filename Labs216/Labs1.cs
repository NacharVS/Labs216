using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova216
{
    class Labs1
    {
        static public void Quadraticequation(double a, double b, double c)
        {
            double D = (b * b) - (4 * a * c);
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            //if (D == 0)
            //    Console.WriteLine($"X={-b/(2*a)}");
            //else
            Console.WriteLine($"{x1},{x2}");
        }

        static public void PythagoreanTheorem()
        {
            Console.WriteLine("Введите a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите в");
            double в = double.Parse(Console.ReadLine());
            double c = a * a + в * в;
            Console.WriteLine(c * c);
        }
        public static void Circumference()
        {
            Console.WriteLine("Радиус");
            double r = double.Parse(Console.ReadLine());
            if (r < 0)
                Console.WriteLine("Значение неправильное");
            else
                Console.WriteLine($"Значение круга - {2 * Math.PI * r}");
        }
        public static void Areaofcircle()
        {
            Console.WriteLine("радиус");
            double r = double.Parse(Console.ReadLine());
            if (r < 0)
                Console.WriteLine("Значение неправильно");
            else
                Console.WriteLine($"Площадь круга - {Math.PI * r * r} ");
        }

        public static void ParallepipedVolume()
        {
            Console.WriteLine("Введите a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            double c = double.Parse(Console.ReadLine());
            double V = a * b * c;
            Console.WriteLine(V);
        }
        public static void voltage()
        {
            Console.WriteLine("I");
            double I = double.Parse(Console.ReadLine());
            Console.WriteLine("R");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("U");
            double U = I * R;
            Console.WriteLine(U);
        }
        public static void amperage()
        {
            Console.WriteLine("U");
            double U = double.Parse(Console.ReadLine());
            Console.WriteLine("R");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("I");
            double I = U / R;
            Console.WriteLine(I);
        }
        public static void resisitance()
        {
            Console.WriteLine("I");
            double I = double.Parse(Console.ReadLine());
            Console.WriteLine("U");
            double U = double.Parse(Console.ReadLine());
            Console.WriteLine("R");
            double R = U / I;
            Console.WriteLine(R);
        }
    }
}