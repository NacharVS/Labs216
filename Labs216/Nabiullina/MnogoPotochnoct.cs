using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Labs216.Nabiullina
{
    class MnogoPotochnoct
    {
        public static void Prr()
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] arraysum = new int[10];
            Random rnd = new Random();
            Task tackOne = new Task(() =>
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = rnd.Next(100);
                    array2[i] = rnd.Next(100);
                    Console.WriteLine($"array1 [{i}] ={array1[i]} array1 [{i}] = {array2[i]}");
                }
            });
            tackOne.Start();
            Task taskTwo = new Task(() =>
            {
                Thread.Sleep(100);
                for (int i = 0; i < array2.Length; i++)
                {
                    arraysum[i] = array1[i] + array2[i];
                    Console.WriteLine($"array1[{i}] + array2[{i}] = {arraysum[i]}");
                }
            });
            taskTwo.Start();
            taskTwo.Wait();
            for (int i = 0; i < arraysum.Length; i++)
            {
                for( int j = 0; j< arraysum.Length - 1 - i; j++)
                {
                    if(arraysum[j]>arraysum[i+1])
                    {
                        int buf = arraysum[j];
                        arraysum[j] = arraysum[j + 1];
                        arraysum[j + 1] = buf;
                    }
                }
            }
        }
    }
    //    public static void Thread1()
    //    {
    //        Console.WriteLine("1 massiv");
    //        int[] array = new int[10];
    //        Random rnd = new Random();
    //        for (int i = 0; i < 10; i++)
    //        {
    //            array[i] = rnd.Next(10, 100);
    //            Console.WriteLine(array[i]);
    //        }
    //    }
    //    public static void Thread2()
    //    {
    //        Console.WriteLine("2 massiv");
    //        int[] array = new int[10];
    //        Random rnd = new Random();
    //        for (int i = 0; i < 10; i++)
    //        {
    //            array[i] = rnd.Next(10, 100);
    //            Console.WriteLine(array[i]);
    //        }
    //    }
    //    public static void Thread3()
    //    {
    //        Console.WriteLine("Summ massiv");
    //        int[] array = new int[10];
    //        for (int i = 0; i < 10; i++)
    //        {
    //        }
    //    }
    //    public static void Thread4()
    //    {
           
    //    }
    //}

}
// есть 2 массива, одномерн., заполнить тут же их сложить, сложение чуть позже\отсортировать после суммы, как хочу\ заполнять параллельно\