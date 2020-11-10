using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev.Delegates
{
    class GeneralOffice
    {
        public static void sozdaniemassiva()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[] massiff = new int[a];
            Random rnd = new Random();
            for (int b = 0; b < massiff.Length; b++)
            {
                massiff[b] = rnd.Next(1, 100);
            }
        }
        public static void Sortirovka()
        {
            sozdaniemassiva();
                Array.Sort(massiff);
                Console.WriteLine(massiff[b]);
            }
        }
        public static void Summa()
        {
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int[] massiff = new int[a];
                Random rnd = new Random();
                for (int b = 0; b < massiff.Length; b++)
                {
                    massiff[b] = rnd.Next(1, 100);
                }
                Console.WriteLine($"{massiff.Sum()}= сумма массива");
            }
        }
        public static void Max()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[] massiff = new int[a];
            Random rnd = new Random();
            for (int b = 0; b < massiff.Length; b++)
            {
                massiff[b] = rnd.Next(1, 100);
            }
            Console.WriteLine(massiff.Max);
        }
            }