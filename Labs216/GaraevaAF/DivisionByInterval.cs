using System;
using System.ComponentModel.DataAnnotations;

namespace Labs216.GaraevaAF
{
    class DivisionByInterval
    {
        static public void DivisionByInterval1()
        {
            Console.WriteLine("Enter a number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("We will divide from what number?");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("We wiil divide up to what number?");
            double c = double.Parse(Console.ReadLine());
            for (double i = b; i <=c; i++)
            {
                if (i != 0)
                {
                    double x = 0;
                    x = a / i;
                    Console.WriteLine($"{a} divide up to {i} = {x}");
                }
            }
               


        }
    }
}
