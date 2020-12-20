using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Topunova
{
    class Collections1
    {
        static void Main(string[] args)
        {
            int[] arr1 new int[5];
            int[] arr2 new int[5];
            int[] arr3 new int[5];

            Task taskOne = new Task(() =>
            {
                for (int i = 0; 1 < arr1.Length; i++)
                {
                    arr1[1] = new Random().Next(10);
                    arr2[1] = new Random().Next(10);

                    Console.WriteLine($"arr1[{i}] = {arr1[i]} arr2[{i}] = {arr2[i]}");
                }
            }
        }
    }
}
