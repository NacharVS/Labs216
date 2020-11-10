using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Delegates
{
    class BranchOffice
    {
        private delegate int[] ArrayOperation(int[] array);
        

        public static void Main(string[] args)
        {
            ArrayOperation operation = GeneralOffice.Sorting;
            operation += GeneralOffice.SummMassive;
            operation += GeneralOffice.max;

            Random rnd = new Random();
            int[] array = new int[rnd.Next(5, 10)];
            for (int i = 0; i < array.Length -1; i++)
            {
                array[i] = rnd.Next(1, 100);
            }

            Console.WriteLine("array");

            for (int i=0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
            Console.WriteLine();
            Console.WriteLine();

            operation();
        }

             // ввод чисел
        

    }
}
