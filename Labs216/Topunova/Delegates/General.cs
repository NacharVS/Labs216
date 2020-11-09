using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class General
    {
        private delegate void GeneralOffice();

        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5, 6};
            
            for (int i = 0; i < array.lenght; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
        
    }
}
