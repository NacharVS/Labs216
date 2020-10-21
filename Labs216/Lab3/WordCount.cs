using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Lab3
{
    class WordCount
    {
        static public void WordCount1()
        {
            string sentence = "Мой метод - ценить жизнь и её моменты";
            string[] words = sentence.Split(' ');

            foreach (var word in words)
            {
                Console.WriteLine($"{word}");
            }
            Console.WriteLine("words count: " + sentence.Length);
        }
        
    }
}
