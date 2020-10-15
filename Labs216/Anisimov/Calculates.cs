using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov
{
        class Calculates
        {
            /*
            static void Main(string[] args)
            {
                string chk = "y";
                while (chk == "y")
                {
                    Console.WriteLine("What do you want to calculate? 1 -- ax^2 - bx + c || 2 -- c^2=a^2+b^2 || 3 -- circumference || 4 -- area of circle || 5 -- parallelepiped's Volume || 6 -- amperage|resistanese|voltage.");
                    int choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            Calculates.QuadraticEquation();
                            break;
                        case 2:
                            Calculates.PythagoreanTheorem();
                            break;
                        case 3:
                            Calculates.Circumference();
                            break;
                        case 4:
                            Calculates.AreaOfCircle();
                            break;
                        case 5:
                            Calculates.ParallepipedVolume();
                            break;
                        case 6:
                            Calculates.AmperResVolt();
                            break;
                        default:
                            Console.WriteLine($"Wrong input. ({choose})");
                            break;
                    }
                    Console.WriteLine("Continue? y/n");
                    chk = Console.ReadLine();
                }
            }
            */
            public static void QuadraticEquation()
            {
                Console.WriteLine("Enter a:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter b:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter c:");
                double c = double.Parse(Console.ReadLine());
                double d = b * b - 4 * a * c;
                double sqrt_d = Math.Sqrt(d);
                double x1 = (-b + sqrt_d) / (2 * a);
                double x2 = (-b - sqrt_d) / (2 * a);
                if (d == 0)
                    Console.WriteLine($"X = {x1}");
                else
                    Console.WriteLine($"X = {x1} ; {x2}");
            }
            public static void PythagoreanTheorem()
            {
                Console.WriteLine("Type -1 in the value you want to find (It will find c and c^2 by defualt)");
                Console.Write("a:");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b:");
                double b = double.Parse(Console.ReadLine());
                Console.Write("c:");
                double c = double.Parse(Console.ReadLine());
                if (a == -1)
                {
                    a = c * c - b * b;
                    Console.WriteLine($"hypotenuse square -- {a} | hypotenuse -- {Math.Sqrt(a)}");
                }
                else if (b == -1)
                {
                    b = c * c - a * a;
                    Console.WriteLine($"hypotenuse square -- {b} | hypotenuse -- {Math.Sqrt(b)}");
                }
                else
                {
                    c = a * a + b * b;
                    Console.WriteLine($"hypotenuse square -- {c} | hypotenuse -- {Math.Sqrt(c)}");
                }
            }
            public static void Circumference()
            {
                Console.WriteLine("radius:");
                double r = double.Parse(Console.ReadLine());
                if (r < 0) Console.WriteLine("wrong value");
                else Console.WriteLine($"Circumference -- {2 * Math.PI * r}");
            }
            public static void AreaOfCircle()
            {
                Console.WriteLine("radius:");
                double r = double.Parse(Console.ReadLine());
                if (r < 0) Console.WriteLine("wrong value");
                else Console.WriteLine($"Area of a circle -- {Math.PI * r * r}");
            }
            public static void ParallepipedVolume()
            {
                Console.Write("a:");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b:");
                double b = double.Parse(Console.ReadLine());
                Console.Write("c:");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine($"Parallepiped's Volume -- {a * b * c}");
            }
            public static void AmperResVolt()
            {
                Console.WriteLine("Type -1 in the value you want to find(It will find voltage by defualt)");
                Console.Write("I:");
                double I = double.Parse(Console.ReadLine());
                Console.Write("R:");
                double R = double.Parse(Console.ReadLine());
                Console.Write("U:");
                double U = double.Parse(Console.ReadLine());
                if (I == -1)
                {
                    I = U / R;
                    Console.WriteLine($"amperage -- {I}");
                }
                else if (R == -1)
                {
                    R = U / I;
                    Console.WriteLine($"resistance -- {R}");
                }
                else
                {
                    U = I * R;
                    Console.WriteLine($"voltage -- {U}");
                }
            }
        }
    }

