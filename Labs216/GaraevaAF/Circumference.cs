using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.GaraevaAF
{
    class Circumference
    {
        static public void Circumference1()
        {
            Console.WriteLine("Formula Circumference c = 2Пr ");
            Console.WriteLine("Enter the radius of the circle");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Constant П = 3,14");
            double c = 0;
            {
                if (r > 0)
                {
                    c = 2 * 3,14 * r;
                    Console.WriteLine(c);
                }
            }
            


        }
    }
}
