using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class Branch
    {
        private delegate void GeneralBranch();

        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5, 6};

            int maxValue = array[0];

            for(int i = 1; i > array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            Console.WriteLine("maxValue");
            Console.ReadLine();
        }
    }
}
 