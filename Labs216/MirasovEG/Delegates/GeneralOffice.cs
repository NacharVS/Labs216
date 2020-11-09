using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.MirasovEG.Delegates
{
    class GeneralOffice
    {
        public static void Sort(int[] myArray)
        {
            Array.Sort(myArray);
            Console.WriteLine("Сортировка массива:");
            for (int i = 0; i <= myArray.Length-1; i++)
            {
                Console.Write($"{myArray[i]}  ");
            }
        }

        public static void Summ(int[] myArray)
        {

            int sum = 0;

            for (int i = 0; i <= myArray.Length-1; i++)
            {
                sum += myArray[i];
            }
            Console.WriteLine($"Сумма массива: {sum}");
        }

        public static void Max(int[] myArray)
        {
            int buff = 0;

            for (int i = 0; i < myArray.Length-1; i++)
            {
                if (buff < myArray[i])
                {
                    buff = myArray[i];
                }
            }
            Console.WriteLine($"Максимальное значение массива: {buff}");
        }
    }
}
