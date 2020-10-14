using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov
{
    class Program
    {
        static void Main(string[] args)
        {
            DivisionByInterval.divisionbyinterval();
        }
    }
    public class DivisionByInterval
    {
        public static void divisionbyinterval()
        {
            Console.WriteLine("Enter number");
            double numb = double.Parse(Console.ReadLine());
            Console.WriteLine("First number of interval:");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Last numver of interval:");
            double last = double.Parse(Console.ReadLine());
            for (double i = first; i < last+1;i++)
            {
                if (i == 0) continue;
                Console.WriteLine($"{numb}/{i} -- {numb / i}");
            }
        }
    }
}
