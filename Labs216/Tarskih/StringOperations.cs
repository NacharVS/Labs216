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

        public static void Palindrome(string s)
        {
            s = s.Replace(" ", "");
            char[] str = s.ToCharArray();
            char[] reverse = str.Reverse().ToArray();
            int count = 0;
            for (int i = 0; i < str.Length; i = i + 1)
            {
                if (reverse[i] == str[i])
                    count += 1;
            }
            if (count == str.Length)
                Console.WriteLine("Эта строка являфется палиндромом");
            else
                Console.WriteLine("Эта строка не является палиндромом");
        }
    }
}
