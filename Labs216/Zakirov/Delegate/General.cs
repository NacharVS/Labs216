using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Delegate
{
    class General
    {

        public static void Sorting(int[] mass)
        {
            Array.Sort(mass);
            Console.Write("Sorting:");
            for (int a = 0; a < mass.Length; a++)
            {
                Console.Write($" {mass[a]}");

            }

        }
         public static void SummArray(int[] mass)
        {
            int Summ = 0;
            for (int a = 0; a < mass.Length; a++)
            {
                if (mass[a] > 0)
                    Summ += mass[a];
            }
            Console.WriteLine();
            Console.Write($"Summ: {Summ}");
        }
        public static void MaxValue(int[] mass)
        {
            int max = 0;
            for (int a = 0; a < mass.Length; a++)
            {
                Console.Write($" {mass[a]}");
                if (max < mass[a])
                    max = mass[a];
            }
            Console.WriteLine();
            Console.WriteLine($"max: {max}");
        }


    }
}

