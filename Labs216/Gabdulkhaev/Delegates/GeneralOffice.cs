using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            int a = Convert.ToInt32(Console.ReadLine());
            int[] massiff = new int[a];
            Random rnd = new Random();
            for (int b = 0; b < massiff.Length; b++)
            {
                massiff[b] = rnd.Next(1, 100);
                if (b == 0) continue;
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
//            Console.WriteLine(massiff.Max);
        }
        public static void Summatwomassives()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[] massiff = new int[10];
            Random rnd = new Random();
            for (int b = 10; b < massiff.Length; b++)
            {
                massiff[b] = rnd.Next(1, 100);
            }
            int a2 = Convert.ToInt32(Console.ReadLine());
            int[] massiff2 = new int[10];
            Random rnd2 = new Random();
            for (int b = 0; b < massiff.Length; b++)
            {
                massiff2[b] = rnd.Next(1, 100);
            }
            int a3 = Convert.ToInt32(Console.ReadLine());
            int[] massiff3 = new int[10];
            Random rnd3 = new Random();
            for (int b = 0; b < massiff.Length; b++)
            {
                massiff3[b] = massiff[b] + massiff2[b];
            }
        }
        public static void Proizvednieofmassives()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[] massiff = new int[10];
            Random rnd = new Random();
            for (int b = 10; b < massiff.Length; b++)
            {
                massiff[b] = rnd.Next(1, 100);
            }
            int a2 = Convert.ToInt32(Console.ReadLine());
            int[] massiff2 = new int[10];
            Random rnd2 = new Random();
            for (int b = 0; b < massiff.Length; b++)
            {
                massiff2[b] = rnd.Next(1, 100);
            }
            int a3 = Convert.ToInt32(Console.ReadLine());
            int[] massiff3 = new int[10];
            Random rnd3 = new Random();
            for (int b = 0; b < massiff.Length; b++)
            {
                massiff3[b] = massiff[b] * massiff2[b];
            }
        }
            public static void Paznostofmassives()
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int[] massiff = new int[10];
                Random rnd = new Random();
                for (int b = 10; b < massiff.Length; b++)
                {
                    massiff[b] = rnd.Next(1, 100);
                }
                int a2 = Convert.ToInt32(Console.ReadLine());
                int[] massiff2 = new int[10];
                Random rnd2 = new Random();
                for (int b = 0; b < massiff.Length; b++)
                {
                    massiff2[b] = rnd.Next(1, 100);
                }
                int a3 = Convert.ToInt32(Console.ReadLine());
                int[] massiff3 = new int[10];
                Random rnd3 = new Random();
                for (int b = 0; b < massiff.Length; b++)
                {
                    massiff3[b] = massiff[b] - massiff2[b];
                }
            }
        }
        }