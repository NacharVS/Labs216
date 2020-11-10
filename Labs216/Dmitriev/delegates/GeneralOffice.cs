using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev.delegates
{
    class GeneralOffice
    {
        public static void Corterovka()
        {
            int[] Array = new int[10];
            Random rnd = new Random();

            for (int a = 0; a > Array.Length; a++)
            {
                Array[a] = rnd.Next(20, 50);
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
