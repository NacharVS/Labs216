using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev.delegates
{
    class GeneralOffice
    {
        public static void Massivesort()
        {
            int[] Array = new int[25];
            Random rnd = new Random();

            for (int a = 0; a > Array.Length; a++)
            {
                Array[a] = rnd.Next(30, 50);
            }
        }
        public static void Summa()
        {

        }
        public static void Maxx()
        {

        }
    }
}
