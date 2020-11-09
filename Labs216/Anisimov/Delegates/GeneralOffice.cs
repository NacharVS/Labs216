using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov.Delegates
{
    class GeneralOffice
    {
        public static int[] SortMassive(int[] array)
        {
            int buff;
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1 - j; i++)
                    if (array[i] > array[i + 1])
                    {
                        buff = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = buff;
                    }
            }
            
            for (int i = 0;i < array.Length; i++)
            {
                Console.Write($"| {array[i]} |");
            }

            return array;
        }

        public static int SummMassive(int[] array)
        {
            int res = 0;
            foreach (int item in array)
            {
                res += item;
            }

            Console.WriteLine($"Сумма -- {res}");

            return res;
        }

        public static int MaxMassive(int[] array)
        {
            int max = 0;
            foreach (int item in array)
            {
                if (item > max) max = item;
            }

            Console.WriteLine($"Максимум -- {max}");

            return max;
        }
    }
}
