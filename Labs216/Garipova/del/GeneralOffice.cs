using System;
using System.Linq.Expressions;

namespace Labs216.Garipova.del
{
    class GeneralOffice
    {
        public static void Sorterovka(int[] mass)
        {
            Array.Sort(mass);
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine($"{mass[i]}");
            }
        }

        public static void Summa(int[] mass)
        {
            int summ = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                    summ += mass[i];
            }
            Console.WriteLine();
            Console.WriteLine($"summa: {summ}");
        }
    }
}


        //public static void Maxx(int[] mass)
        //{
        //    for (int i = 0; i < mass.Length; i++)
        //    {

        //    }
        //}
    

