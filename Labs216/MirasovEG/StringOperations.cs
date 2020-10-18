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
            Console.Write("Odd characters in the string: ");

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    continue;
                if (i % 2 == 0)
                    Console.Write(s[i]);
            }

            Console.WriteLine();

            Console.Write("Even characters in the string: ");
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    continue;
                if (i % 2 != 0)
                    Console.Write(s[i]);
                
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
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == s[s.Length - 1 - i])
                    count += 1;
            }
            if (count == s.Length)
                Console.WriteLine("This string is a palindrome");
            else
                Console.WriteLine("This string is not a palindrome");
        }
    }
}
