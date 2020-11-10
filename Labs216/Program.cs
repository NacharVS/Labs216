using System;
using Labs216.Zakirov;
using Labs216.Zakirov.Delegate;

namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] array = new int[25];
                Random rnb = new Random();
                for (int a = 0; a < array.Length; a++)
                {
                    array[a] = rnb.Next(99);
                }
                Branch.AinurInvoke(array);
            }
        }
    }
}
