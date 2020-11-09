using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Delegates
{
    class MinorOffice
    {
        static public void SummArray()
        {
            Random rnb = new Random();
            int[] array = new int[17];
            int Summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnb.Next(99);
                Console.Write($" {array[i]}");
                if (array[i] > 0)
                    Summ += array[i];
            }
            Console.WriteLine();
            Console.Write($"Summ: {Summ}");
        }
    }
}
