using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.MirasovEG
{
    class DivisionByInterval
    {
        static void Main(string[] args)
        {
            DivisionbyInterval();
        }

        static public void DivisionbyInterval()
        {
            Console.WriteLine("Enter number");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter begin interval");
            double first = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter end interval");
            double second = double.Parse(Console.ReadLine());

            for (double i = first; i <= second; i++)
            {
                if (i==0) continue;
                double devision = number / i;
                Console.WriteLine($"Результат деления {number} на {i} = {devision}");
            }
        }
        
    }
}
