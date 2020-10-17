using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Labs216.Anisimov
{
    class StringOperation
    {
        public static void MethodsCall() //Method just to call other methods (for run and check this program)
        {
            while (true)
            {
                Console.WriteLine("Enter sring:");
                string str = Console.ReadLine();
                Console.WriteLine("What do you want? 1 -- Separate even and odd characters | 2 -- Count the number of words in a sring | 3 -- Check if the string is a palindrome | 4 -- All of the above");
                int user_choose = int.Parse(Console.ReadLine());
                switch (user_choose)
                {
                    case 1:
                        OddEven(str);
                        break;
                    case 2:
                        WordCount(str);
                        break;
                    case 3:
                        Palindrome(str);
                        break;
                    case 4:
                        OddEven(str);
                        WordCount(str);
                        Palindrome(str);
                        break;
                    default:
                        Console.WriteLine("Wrong number");
                        break;
                }
                Console.WriteLine("Continue? -- y/n");
                string chk = Console.ReadLine();
                if (chk == "n") break;
            }
        }
        public static void OddEven(string a)
        {
            // Space (" ") is a char
            string even = "";
            string odd = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0) even = even + a[i];
                else odd = odd + a[i];
            }
            // Space (" ") isn't a char
            a = a.Replace(" ", "");
            string _even = "";
            string _odd = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0) _even = _even + a[i];
                else _odd = _odd + a[i];
            }
            Console.WriteLine("With spaces");
            Console.WriteLine($"odd -- ({odd}) ");
            Console.WriteLine($"even -- ({even})");
            Console.WriteLine("Without spaces");
            Console.WriteLine($"odd -- ({_odd}) ");
            Console.WriteLine($"even -- ({_even})");
            Console.WriteLine();
        }
        public static void WordCount(string a)
        {
            int count = 0;
            string[] str = a.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in str) count = count + 1;
            Console.WriteLine($"{count} words in this string");
            Console.WriteLine();
        }
        public static void Palindrome(string a)
        {
            string b = "";
            a = a.Replace(" ", "");
            for (int i = 0; i < a.Length; i++)
            {
                b += a[a.Length - i - 1];
            }
            if (a == b) Console.WriteLine("It is a palindome");
            else Console.WriteLine("It is not a palindrome");
            Console.WriteLine();
        }
    }
}
