using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Khabibullina.delegate_etot_vash
{
    class brunch
    {
        static public void sum()
        {
            int[] array = new int[5];
            Random rnd = new Random();
            int x = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100, 200);
                Console.WriteLine($"{array[i]}");
            }
            for (int i = 0; i < array.Length; i++)
            {
                x += array[i];
            }
            Console.WriteLine($"Summ: {x}");
        }
        static public void sort()
        {
            int[] array = new int[3];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
            }
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
        static public void max()
        {
            int[] array = new int[7];
            Random rnd = new Random();
            int y = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100, 200);
                Console.WriteLine($"{array[i]}");
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (y < array[i])
                {
                    y = array[i];
                }
            }
            Console.WriteLine($" max: {y}");
        }
    }
}
