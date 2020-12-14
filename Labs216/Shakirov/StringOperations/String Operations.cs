using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Labs216.Shakirov
//{
//    class String_Operations
//    {
//        public static void OddEven(string s)
//        {
//            char[] str = s.ToCharArray();

//            Console.WriteLine("Odd characters in the stribg: ");

//            for (int i = 0; i < str.Length; i++)
//            {
//                if (str[i] == ' ')
//                    continue;
//                if (i % 2 == 0)
//                    Console.WriteLine(str[i]);
//            }
            
//            Console.WriteLine();

//            Console.Write("Even characters in the string ");
//            for (int i = 0; i < str.Length; i++)
//            {
//                if (str[i] == ' ')
//                    continue;
//                if (i % 2 != 0)
//                    Console.Write(str[i]);
//            }

//        }

//        public static void WordCount(string s)
//        {
//            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//            Console.WriteLine($"Number of words per line = {words.Length}");
//        }


//        public static void Palindrome(string s)
//        {
//            s = s.Replace(" ", "");
//            char[] str = s.ToCharArray();
//            char[] reverse = str.Reverse().ToArray();
//            int count = 0;
//            for (int i = 0; i < str.Length; i++)
//            {
//                if (reverse[i] == str[i])
//                    count += 1;               
//            }
//            if (count == str.Length)
//                Console.WriteLine("This string is a palindrome");
//            else
//                Console.WriteLine("This string is not a palindrome");

//        }
//    }
//}
