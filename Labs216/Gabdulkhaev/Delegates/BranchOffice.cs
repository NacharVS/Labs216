using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Labs216.Gabdulkhaev;

namespace Labs216.Gabdulkhaev.Delegates
{
    class BranchOffice
    {
        private delegate void IM(int[] massiff);
        public static void Lab()
        {
       //     IM lab = GeneralOffice.Sortirovka;
     //       lab += GeneralOffice.Summa;
   //         lab += GeneralOffice.Max;1
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
