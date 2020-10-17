using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Labs216.MirasovEG
{
    class StringOperations
    {
        public static void OddEven(string s)
        {
            char[] str = s.ToCharArray();

            Console.Write("Odd characters in the string: ");

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    continue;
                if (i % 2 == 0)
                    Console.Write(str[i]);
            }

            Console.WriteLine();

            Console.Write("Even characters in the string: ");
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    continue;
                if (i % 2 != 0)
                    Console.Write(str[i]);
                
            }
        }
        
        public static void WordCount(string s)
        {
            string[] words = s.Split(' ' , StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Number of words per line = {words.Length}");
        }


        public static void Palindrome(string s)
        {
            s = s.Replace(" ", "");
            char[] str = s.ToArray();
            char[] reverse = str.Reverse().ToArray();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (reverse[i] == str[i])
                    count += 1;
            }
            if (count == str.Length)
                Console.WriteLine("This string is a palindrome");
            else
                Console.WriteLine("This string is not a palindrome");
        }
    }
}
