using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Delegates
{
    class BranchOffice
    {
        private delegate void ArrayOperation(int[] array);
        private delegate void OperationWithArrays(int[] array1, int[] array2);

        public static void Run()
        {
            ArrayOperation operation = GeneralOffice.Sorting;
            operation += GeneralOffice.SummMassive;
            operation += GeneralOffice.max;

            OperationWithArrays arrays = GeneralOffice.ArraySumm;
            arrays += GeneralOffice.ArrayDifference;
            arrays += GeneralOffice.ArrayComposition;

                    Random rnd = new Random();
                    int[] array = new int[rnd.Next(5, 10)];
                    for (int i = 0; i < array.Length -1; i++)
                    {
                        array[i] = rnd.Next(1, 100);
                    }

                    Console.WriteLine(" Array");

                    for (int i=0; i < array.Length; i++)
                    {
                        Console.Write($"|{array[i]}| ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();

            operation(array);



                    int[] array1 = new int[rnd.Next(5, 10)];
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        array[i] = rnd.Next(1, 100);
                    }

                        Console.Write($"Array1: |{array1[i]|} ");

                    int[] array2= new int[rnd.Next(5, 10)];
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        array[i] = rnd.Next(1, 100);
                    }



        }         
    }
}
