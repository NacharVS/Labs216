using Labs216.Delegates;
using Labs216.GaraevaAF;
using Labs216.Lab2;
using Labs216.Lab3;
using Labs216.Lab4;
using System;

namespace Labs216
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int[] array = new int[17];
            Random rnb = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnb.Next(99);
            }
            BranchOffice.RabbitInvoke(array);
        }
        
    }
}
