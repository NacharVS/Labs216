using System;
using Labs216.Dmitriev;
using Labs216.Dmitriev.delegates;

namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            BranchOffice.sergo dmitriev = GeneralOffice.Massivesort;
            dmitriev += GeneralOffice.MaxValue;
            dmitriev += GeneralOffice.Summamassiv;

            int[] array = new int[11];
            Random rnb = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnb.Next(99);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            dmitriev(array);

        }
    }
}
