using System;

namespace Labs216.Delegates
{
    class GeneralOffice
    {
        static public void SummArray(int[] mass)
        {
            int Summ = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                    Summ += mass[i];
            }
            Console.WriteLine();
            Console.Write($"Summ: {Summ}");
        }
        public static void MaxValue(int[] mass)
        {
            int max = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($" {mass[i]}");
                if (max < mass[i])
                    max = mass[i];
            }
            Console.WriteLine();
            Console.WriteLine($"max: {max}");
        }
        public static void Sorting(int[] mass)
        {
            Array.Sort(mass);
            Console.Write("Sorting:");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($" {mass[i]}");
               
            }
            
        }
    }
}
