using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov.Delegates
{
    class GeneralOffice
    {
        public static void SortArray(int[] array)
        {
            Array.Sort(array);

            Console.WriteLine("Sort array");

            Console.WriteLine();

            for (int i = 0;i < array.Length; i++)
            {
                Console.Write($"| {array[i]} |");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public static void SummArray(int[] array)
        {

            Console.WriteLine("Summ array");

            Console.WriteLine();

            int res = 0;
            foreach (int item in array)
            {
                res += item;
            }

            Console.WriteLine($"Summ -- {res}");

            Console.WriteLine();
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

            Console.WriteLine();
        }

        public static void SummOfMassives(int[] array1, int[] array2)
        {
            int[] arrayRes = new int[array1.Length];
            for (int i = 0; i < array1.Length - 1 ;i++)
            {
                arrayRes[i] = array1[i] + array2[i];
            }

            Console.WriteLine();

            Console.WriteLine("SummOfArrays");

            for (int i = 0; i < arrayRes.Length; i++)
            {
                Console.Write($"| {arrayRes[i]} |");
            }

            Console.WriteLine();
        }

        public static void DifOfMassives(int[] array1, int[] array2)
        {
            int[] arrayRes = new int[array1.Length];
            for (int i = 0; i < array1.Length - 1; i++)
            {
                arrayRes[i] = array1[i] - array2[i];
            }

            Console.WriteLine();

            Console.WriteLine("DiffOfArrays");

            for (int i = 0; i < arrayRes.Length; i++)
            {
                Console.Write($"| {arrayRes[i]} |");
            }

            Console.WriteLine();
        }

        public static void ProizvedenieOfMassives(int[] array1, int[] array2)
        {
            int[] arrayRes = new int[array1.Length];
            for (int i = 0; i < array1.Length - 1; i++)
            {
                arrayRes[i] = array1[i] * array2[i];
            }

            Console.WriteLine();

            Console.WriteLine("ProizvedenieOfMassives");

            for (int i = 0; i < arrayRes.Length; i++)
            {
                Console.Write($"| {arrayRes[i]} |");
            }

            Console.WriteLine();
        }
    }
}
