using System;

namespace Labs216.Delegates
{
    class GeneralOffice
    {
        public static void Sorting()
        {
            Random rnb = new Random();
            int[] array = new int[17];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnb.Next(10, 99);
            }
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");
            }
        }
    }
}
