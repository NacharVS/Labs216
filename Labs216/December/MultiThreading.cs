using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Labs216.Multithreading
{
    class MultiThreading
    {
        public static void Array()
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] sumarray = new int[10];
            Random rnd = new Random();

            Task task1 = new Task(() =>
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = rnd.Next(10, 100);
                    array2[i] = rnd.Next(10, 100);
                    sumarray[i] = array1[i] + array2[i];
                    Console.WriteLine($"{i})  {array1[i]}    {i})  {array2[i]} = {sumarray[i]} ");

                }
            });
            task1.Start();
            task1.Wait();

           
        }
    }
}
