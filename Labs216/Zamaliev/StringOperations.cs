using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zamaliev
{
    class StringOperations
    {
        static public void SOp(string s)
        {

            Console.WriteLine("Нечётный символ в строке: ");
            for (int a = 0; a < s.Length; a++)
            {
                if (s[a] == ' ')
                    continue;
                if ((a+1) % 2 != 0)
                    Console.Write($"{s[a]}|");
            }

            Console.WriteLine();

            Console.Write("Чётный символ в строке: ");
            for (int a = 0; a < s.Length; a++)
            {
                if (s[a] == ' ')
                    continue;
                if ((a+1) % 2 == 0)
                    Console.Write($"{s[a]}|");
            }
        }

        public static void WordsCount(string s)
        {
            string[] words = s.Split('a', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Количество слов в строке = {words.Length}");
        }

        public static void Palindrome(string n)
        {
            string m = "";
            n = n.Replace(" ", "");
            for (int i = 0; i < n.Length; i++) 
            {
                m += n[n.Length - i - 1];
            }
            if (n == m) Console.WriteLine("Эта строка является палиндромом");
            else Console.WriteLine("Эта строка не является палиндромом");
            Console.WriteLine();
        }
       
    }
}
