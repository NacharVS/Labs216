using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Delegates
{
    class GeneralOffice
    {
        public static void Sorting(int[] array)
        {
            Array.Sort(array);
            Console.WriteLine(" Sort Array");

                int buf;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array [i] > array [j])
                        {
                            buf = array [i];
                            array[i] = array[j];
                            array[j] = buf;
                        }
                    }
                }            
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"|{array[i]}| ");                    
                }
            Console.WriteLine();
            Console.WriteLine();
        }



        public static void SummMassive(int[] array)
        {
            Array.Sort(array);
            Console.WriteLine(" Summ Array's Elements");
            int res = 0;
            foreach (int item in array)
            {
                res += item;
            }
            Console.Write($"|{res}|");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void max(int[] array)
        {            
            Array.Sort(array);
            Console.WriteLine(" Max Array's Element");
            int maxValue = array[array.Length - 1];
            Console.Write($"|{maxValue}|");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        


        public static void ArraySumm(int[] array1, int[] array2)
        {
            int[] arrayRes = new int[array1.Length];
            for (int i = 0; i < array1.Length - 1; i++)
            {
                arrayRes[i] = array1[i] + array2[i];
            }

            Console.WriteLine();
            Console.WriteLine("Summ_Arrays");

            for (int i = 0; i < arrayRes.Length; i++)
            {
                Console.Write($"| {arrayRes[i]} |");
            }
            Console.WriteLine();
        }
        public static void ArrayDifference(int[] array1, int[] array2)
        {
            int[] arrayRes = new int[array1.Length];
            for (int i = 0; i < array1.Length - 1; i++)
            {
                arrayRes[i] = array1[i] - array2[i];
            }

            Console.WriteLine();
            Console.WriteLine("Difference_Arrays");

            for (int i = 0; i < arrayRes.Length; i++)
            {
                Console.Write($"| {arrayRes[i]} |");
            }
            Console.WriteLine();
        }
        public static void ArrayComposition(int[] array1, int[] array2)
        {
            int[] arrayRes = new int[array1.Length];
            for (int i = 0; i < array1.Length - 1; i++)
            {
                arrayRes[i] = array1[i] * array2[i];
            }

            Console.WriteLine();
            Console.WriteLine("Composition_Arrays");

            for (int i = 0; i < arrayRes.Length; i++)
            {
                Console.Write($"| {arrayRes[i]} |");
            }
            Console.WriteLine();
        }
    }
}
