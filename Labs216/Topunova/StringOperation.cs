using System;

namespace Labs216.Topunova
{
    class StringOperation
    {
        public static void Palindrome(string a)
        {
            a = a.Replace(" ", "");
            int count = 0;
                for (int i = 0; i < a.Length; i++);
                {
                if (a[i] == s.Length[string.Length - 1 - i])
                    count += 1;
                }
                {
                if (count == s.Length)
                    Console.WriteLine("String-Palindrome");
                else
                    Console.WriteLine("String-not Palindrome");
                }
        }
    }
}
