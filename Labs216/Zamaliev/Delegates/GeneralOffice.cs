using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zamaliev.Delegates
{
    class GeneralOffice
    {
        public static void Sort(int[] mass)
        {
            Array.Sort(mass);
            Console.Write("Sorting:");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($" {mass[i]}");

            }
        }
        public static void Sum(int[] mass)
        {
            int Summ = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                    Summ += mass[i];
            }
            Console.WriteLine();
            Console.Write($"Summ: {Summ}");
        }
        public static void Max(int[] mass)
        {
            int max = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($" {mass[i]}");
                if (max < mass[i])
                    max = mass[i];
            }
            Console.WriteLine();
            Console.WriteLine($"max: {max}");
        }
        
    }
}