using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Labs216.Garipova.del
{
    class BranchOffice
    {
        public static void Corterovka()
        {
            int[] Array = new int[10];
            Random rnd = new Random();
   
            for (int x = 0; x > Array.Length; x++)
            {
                Array[x] = rnd.Next(20, 50);      
            }

        }
        public static void Summa()
        {
            int[] Array = new int[8];
            Random rnd = new Random();

            for (int x = 0; x > Array.Length; x++)
            {
                Array[x] = rnd.Next(10, 40);
                Console.WriteLine("{Array[x]}");
            }
            int summ = 0;
            summ += Array[x];
            Console.WriteLine("{summ}");
        }
        public static void Maxx()
        {
            int[] Array = new int[8];
            Random rnd = new Random();

            for (int x = 0; x > Array.Length; x++)
            {
                Array[x] = rnd.Next(10, 40);
                Console.WriteLine("{Array[x]}");
            }
             
    }
}
