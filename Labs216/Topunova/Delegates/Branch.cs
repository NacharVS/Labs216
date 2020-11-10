using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    class GeneralBranch 
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5, 6};

            Console.WriteLine($"array");
            Console.WriteLine(array.Max());
        }
    }
    class GeneralOffice 
    {
        public static void Sort()
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };

            Array.Sort(array);
            Console.WriteLine($"array");
            Console.ReadLine();
        }
    }
    class sklad
    {
        public static void Sum()
        {
          
        }
    }
}
 