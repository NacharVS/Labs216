using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov.Delegates
{
    class GeneralOffice
    {
        public static void Sorting()
        {
            Random rnd = new Random();
            int[] array = new int[17];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 99);
            }
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");
            }
        }
    }
}
