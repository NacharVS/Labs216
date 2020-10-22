using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Lab3
{
    class Palindrom
    {
        static public void Palindrom1()
        {
            Console.WriteLine("Enter phrase");
            string phrase = (Console.ReadLine());
            string palindrom = null;
            phrase = phrase.Replace(" ", " ").ToLower();
            for (int i = 0; i < phrase.Length; i++)
            {
                palindrom += phrase[phrase.Length - 1 - i];
            }
            if (phrase == palindrom)
                Console.WriteLine("Is an palindrom");
            else
                Console.WriteLine("No palindrom");

        }
    }
}
