﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov
{
    public class DivisionByInterval
    {
        //Use !Program.cs to run
        public static void divisionbyinterval()
        {
            Console.WriteLine("Enter number");
            double numb = double.Parse(Console.ReadLine());
            Console.WriteLine("First number of interval:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Last numver of interval:");
            int last = int.Parse(Console.ReadLine());
            for (int i = first; i < last+1;i++)
            {
                if (i == 0) continue;
                Console.WriteLine($"{numb}/{i} -- {numb / i}");
            }
        }
        public static double[] divisionbyinterval(double num, int first, int last)
        {
            double[] res = new double[last-first+1];
            for (int i = first; i < last + 1; i++)
            {
                if (i == 0) continue;
                res[i-first] = num/i;
            }
            return res;
        }
    }
}
