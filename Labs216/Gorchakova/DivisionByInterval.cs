using System;
namespace Labs216.Gorchakova
{
   
        public class DivisionByInterval
        {
            static public void FindMet(int a, int b)
            {
                //a-num
                //b-interval
                int c = 0;
                for (int i = 0; i < b; i++)
                {
                    c = i * a;
                    Console.WriteLine($"num={a} ,  interval = {i}. result = {c}");
                }

            }
            static public void PaznostQwadrotow(int a, int b, int c)
            {
                //ax^2 + bx + c
                int D = (b * b) - (4 * a * c);
                int x1 = (-b + Convert.ToInt32(Math.Sqrt(D))) / (2 * a);
                int x2 = (-b - Convert.ToInt32(Math.Sqrt(D))) / (2 * a);
                Console.WriteLine($"D = {D}, X1 = {x1}, X2 = {x2}");
            }
            static public void Pifagor(int a, int b)
            {
                int c = (a * a) + (b * b);
                c = c * c;
                Console.WriteLine($"C = {c}");
            }

            static public void Circumference(double r)
            {

                double c = 2 * 3.14 * r;
                Console.WriteLine($"C = {c}");
            }
            static public void AreaOfCircle(double r)
            {
                double Area = 3.14 * (r * r);
                Console.WriteLine($"Area = {Area}");
            }
            static public void VolumeParallel(int a, int b, int c)
            {
                var V = a * b * c;
                Console.WriteLine($"V = {V}");
            }
            static public void Amperage(double q, double t)
            {
                double I = q / t;
                Console.WriteLine($"Amperage = {I}");
            }
            static public void Resistance(double p, double l, double S)
            {
                double R = (p * l) / S;
                Console.WriteLine($"Resistance = {R}");
            }
            static public void Voltage(double q, double A)
            {
                double V = A / q;
                Console.WriteLine($"Voltage = {V}");
            }
        }
    
}
