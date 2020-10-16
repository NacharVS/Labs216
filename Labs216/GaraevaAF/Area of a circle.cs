using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.GaraevaAF
{
    class Area_of_a_circle
    {
        static public void Area_of_a_circle1()
        {
            Console.WriteLine("Find the area of a circle");
            Console.WriteLine("Enter the radius of the circle");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Constant П = 3.14");
            double S = 0;
            {
                if (r > 0)
                {
                    S = 3.14 * r * r;
                    Console.WriteLine($"{S} = 3.14 * {r} * {r}");
                }
            }

        }
    }
}
