using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina
{
    class DivisionByInterval
    {
       
        static public void DivisionbyInterval()
        {
            Console.WriteLine("Enter a namber:");
            double a = double.Parse (Console.ReadLine());

            Console.WriteLine("Division from what namber?");
            double x = double.Parse (Console.ReadLine());

            Console.WriteLine("Division from what namber?");
            double y = double.Parse (Console.ReadLine());
            for (double b = x; b <= y; b++ )
            {
                double z = a / b;
                Console.WriteLine($"{a} divided by {b} = {z}");

            }
        }
        
    }

}
