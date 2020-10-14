using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.MirasovEG
{
    class DivisionByInterval
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter begin interval");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter end interval");
            int second = int.Parse(Console.ReadLine());

            for (int i = first; i <= second; i++)
            {
                double devision = number / i;
                Console.WriteLine($"Результат деления {number} на {i} = {devision}");
            }
        }
        
    }
}
