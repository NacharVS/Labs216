using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev.delegates
{
    class GeneralOffice
    {
        public static void Massivesort(int[] mass)
        {
            Console.WriteLine("massiv otsortirvan");
            Array.Sort(mass);
            for (int i = 0; i < mass.Length; i++)

            {
                Console.Write($"{mass[i]} ");
            }
            Console.WriteLine();
        }



        public static  void Summamassiv(int[] mass)
        {
            int Summ = 0;
            for (int a = 0; a < mass.Length; a++)
            {
                if (mass[a] > 0)
                    Summ += mass[a];
            }
            Console.WriteLine();
            Console.Write($"Summ: {Summ}");
        }
        public static void MaxValue(int[] mass)
        {
            int max = 0;
            for (int a = 0; a < mass.Length; a++)
            {
                if (max < mass[a])
                    max = mass[a];
            }
            Console.WriteLine();
            Console.WriteLine($"max: {max}");
        }
        
        
            
        
    }

}
