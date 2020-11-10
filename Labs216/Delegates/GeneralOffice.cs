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
            Console.WriteLine();
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
        public static void SumtwoArrays(int[] mass1, int[] mass2)
        {
            int Sum = 0;
            Console.Write("SumTwoArrays:");
            for (int s = 0; s < mass1.Length; s++)
            {
                if (mass1[s] > 0)
                    Sum = mass1[s] + mass2[s];
                Console.Write($" {Sum}");
            }
            Console.WriteLine();
        }
        public static void DifferenceTwoArrays(int[] mass1, int[] mass2)
        {
            int Diference = 0;
            Console.Write("DiterenceTwoArrays:");
            for (int s = 0; s < mass2.Length; s++)
            {
                if (mass2[s] > 0)
                    Diference = mass1[s] - mass2[s];
                Console.Write($" {Diference}");
            }
            Console.WriteLine();
        }
        public static void Multiplication(int[] mass1, int[] mass2)
        {
            int Multiplication = 0;
            Console.Write("Multiplication:");
            for (int s = 0; s < mass1.Length; s++)
            {
                if (mass1[s] > 0)
                    Multiplication = mass1[s] * mass2[s];
                Console.Write($" {Multiplication}");
            }
        }
    }
}
