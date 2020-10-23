using System;
namespace Labs216.Gorchakova
{
    public class StringOperations
    {
        
            public static void AddEven(string s)
            {
                Console.Write("Add characters in the string: ");

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
                string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
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
}
