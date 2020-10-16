using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.GaraevaAF
{
    class Physics
    {
        static public void Physics1()
        {
            Console.WriteLine("Calculate the amperage by Ohm's law on the chain");
            Console.ReadLine();
            Console.WriteLine("Enter voltage value");
            double U = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter resistance value");
            double R = double.Parse(Console.ReadLine());
            double I = 0;
            {
                if (U > 0)
                {
                    I = U / R;
                    Console.WriteLine($"{I} = {U} / {R}");
                }
            }
        }

    }
}
