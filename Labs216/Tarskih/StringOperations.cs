using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih
{
    class StringOperations
    {
        public static void OddSymbol(string s)
        {
            char[] str = s.ToCharArray();

            Console.WriteLine("Нечётный символ в строке: ");
            for (int a = 0; a < str.Length; a = a + 1)
            {
                if (str[a] == ' ')
                    continue;
                if (a % 2 == 0)
                    Console.WriteLine(str[a]);
            }

            Console.WriteLine();

            Console.Write("Чётный символ в строке: ");
            for (int a = 0; a < str.Length; a = a + 1)
            {
                if (str[a] == ' ')
                    continue;
                if (a % 2 != 0)
                    Console.Write(str[a]);
            }
        }

        public static void WordsCount(string s)
        {
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Количество слов в строке = {words.Length}");
        }

        public static void Palindrome(string n)
        {
            string m = "";
            n = n.Replace(" ", "");
            for (int i = 0; i < n.Length; i = i + 1) ;
            {
                m += n[n.Length - i - 1];
            }
            if (n == m) Console.WriteLine("Эта строка не является палиндромом");
            else Console.WriteLine("Эта строка не является палиндромом");
            Console.WriteLine();                   
        }
    }
}
