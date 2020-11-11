using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev.Delegates
{
    class BranchOffice
    {
        private delegate void IM(int[] array);
        public static void Prikol()
        {
            IM prikol = GeneralOffice.Sortirovka;
            prikol += GeneralOffice.Summa;
            prikol += GeneralOffice.Max;
            int a = Convert.ToInt32(Console.ReadLine());
            int[] massiff = new int[a];
            Random rnd = new Random();
            for (int b = 0; b < massiff.Length; b++)
            {
                massiff[b] = rnd.Next(1, 100);
            }
        }
        }
    }
}
