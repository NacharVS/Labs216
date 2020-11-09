using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Delegates
{
    class BranchOffice
    {
        public static void MaxValue()
        {
            Random rnb = new Random();
            int[] array = new int[17];
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnb.Next(99);
                Console.Write($" {array[i]}");
                if (max < array[i])
                    max = array[i];
            }
            Console.WriteLine();
            Console.Write($"max: {max}");
        }
    }
}
