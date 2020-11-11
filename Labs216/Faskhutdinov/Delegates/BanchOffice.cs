using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Faskhutdinov.Delegates
{
    class BanchOffice
    {
        private delegate void ArrayOprerations(int[] array);

        public static void Run()
        {
            ArrayOprerations oprerations = GeneralOffice.SortArray;
            oprerations += GeneralOffice.MaxArray;
            oprerations += GeneralOffice.SummArray;

            Random rnd = new Random();
            int[] array = new int[rnd.Next(5, 10)];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = rnd.Next(1, 100);
            }

            Console.WriteLine("array");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"| {array[i]} |");
            }

            Console.WriteLine();
            Console.WriteLine();

            oprerations(array);
        }
     }
}

