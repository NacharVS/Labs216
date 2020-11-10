using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Faskhutdinov.Delegates
{
    class GeneralOffice
    {
        public static void SortArray(int[] array)
        {
            Array.Sort(array);

            Console.WriteLine("Sort array");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"| {array[i]} |");
            }
        }

        public static void SummArray(int[] array)
        {

            Console.WriteLine("Summ array");

            int res = 0;
            foreach (int item in array)
            {
                res += item;
            }

            Console.WriteLine($"Summ -- {res}");
        }

        public static void MaxArray(int[] array)
        {
            Console.WriteLine("Max array");

            Console.WriteLine();

            int max = 0;
            foreach (int item in array)
            {
                if (item > max) max = item;
            }

            Console.WriteLine($"Max -- {max}");
        }
    }
}


