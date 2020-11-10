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
        public static void Maxx(int[] mass)
        {
            int x = 0;

            for (int i = 0; i < mass.Length; i++)
            {
              if (x > mass[i])
                {
                    x = mass[x];
                }
                Console.WriteLine(x);
            }
        }

        public static void SummaMassivov(int[] masss, int[] masssss)
        {
            int sUm = 0;

            for (int b = 0, b < masss.Length; b++)
            {
                if (masss[b] > 0)
                    sNm = masss[b] + masssss[b];
                Console.WriteLine($"{sUm}");
            }
            Console.WriteLine();
        }
        public static void MultiplicationMassivs(int[] masss, int[] masssss)
        {
            int mult = 0;
            for (int c = 0, c < masss.Length; c++)
            {
                if (masss[c] > 0)
                    mult = masss[c] * masssss[c];
                Console.WriteLine(mult);
            }
        }

        public static void Raznostmassivov(int[] masss, int[] masssss)
        {
            int sweet = 0;

            for (int r = 0; r < masssss.Length; r++)
            {
                if (masssss[r] > 0)
                    sweet = masssss[r] - massss[r];
            }
            Console.WriteLine(sweet);
        }
    }
}


