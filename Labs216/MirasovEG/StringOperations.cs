using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.MirasovEG
{
    class StringOperations
    {
        public static void OddEven(string s)
        {
            char[] str = s.ToCharArray();
            
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                    Console.Write(str[i]);
            }

            Console.WriteLine();
            for (int i = 0; i < str.Length; i++)
            {

                if (i % 2 != 0)
                    Console.Write(str[i]);
                
            }

        }
    }
}
