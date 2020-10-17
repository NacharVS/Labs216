using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
        
        public static void WordCount(string s)
        {
            string[] words = s.Split(' ' , StringSplitOptions.RemoveEmptyEntries);
            

           
            Console.WriteLine($"Количество слов в строке = {words.Length}");
        }
    }
}
