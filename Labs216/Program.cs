using System;
using Labs216.Zamaliev;
using Labs216.Zamaliev.Delegates;

namespace Labs216
{
    class program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random rnb = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnb.Next(10);
            }
            BranchOffice.RobertInvoke(array);
        }
    }
}
