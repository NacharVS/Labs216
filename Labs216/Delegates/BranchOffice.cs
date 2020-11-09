using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Delegates
{
    class BranchOffice
    {
        static public void Povozrastanijy()
        {
            int[] array = new int[5];
            Random rnd = new Random();
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 10);
                
            }
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine(array[i]+ " ");

            }
        }

        static public void Summmasiv()
        {
            int[] array = new int[6];
            Random rnd = new Random();
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 90);
                Console.WriteLine($"{array[i]}");
            }
            for (int i = 0; i < array.Length; i++)
            {
                a += array[i];
                

            }
            Console.WriteLine($"Summ: {a}");
        }
        
        static public void Maxelement()
        {

        }
    }
}
