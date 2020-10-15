using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Labs216.Anisimov
{
    class _program
    {
        static void Main(string[] args)
        {
            // Need to remove comment syntax


            //DivisionByInterval

            //ver 1

            //DivisionByInterval.divisionbyinterval();

            //ver 2

            /*Console.WriteLine("Enter number");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("First number of interval:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Last numver of interval:");
            int last = int.Parse(Console.ReadLine());
            double[] res = new double[last - first + 1];
            res = DivisionByInterval.divisionbyinterval(num, first, last);
            for (int i = first;i < last+1;i++)
            {
                if (i == 0) continue;
                Console.WriteLine($"{num}/{i} -- {res[i-first]}");
            }*/


            //Calculates version 1.0
            /* Class is designed to work with the user, it does not accept or return value to the programm.
             * Maybe I'll make the second version later.*/ 

            /*string chk = "y";
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
            }*/
        }
    }
}
