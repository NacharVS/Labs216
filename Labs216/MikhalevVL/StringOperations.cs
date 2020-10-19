using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labs216.MikhalevVL
{
    class StringOperations
    {
        public static void OddEven()
        {
            string user_string = null;
            user_string = Console.ReadLine();
            if (user_string != null) {
                string[] user_array = user_string.Split(" ");
                string odd_elements = "";
                string even_elements = "";
                for (int i = 0; i < user_array.Length; i++)
                {
                    if (int.Parse(user_array[i]) % 2 == 0)
                    {
                        even_elements = even_elements + " " + user_array[i];
                    }
                    else odd_elements = odd_elements + " " + user_array[i];
                }
                Console.WriteLine($"Odd numbers: {odd_elements}");
                Console.WriteLine($"Even numbers: {even_elements}");
            }
        }
        public static void WordCount()
        {
            var user_string = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (user_string != null)
            {
                Console.WriteLine("Word count: " + user_string.Length);
            }
        }
        public static void Palindrome() {

            string user_string = null;
            Console.Write("Enter a string : ");
            user_string = Console.ReadLine();
            string reversed_string = "";
            if (user_string != null)
            {
                for (int i = user_string.Length - 1; i >= 0; i--)
                {
                    reversed_string += user_string[i].ToString();
                }
                if (reversed_string == user_string)
                {
                    Console.WriteLine("String is Palindrome");
                }
                else
                {
                    Console.WriteLine("String is not Palindrome");
                }
            }
        }
    }
}
