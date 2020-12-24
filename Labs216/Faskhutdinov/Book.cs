using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Faskhutdinov
{
    class Books
    {
        public static void BookOfRead()
        {
            Stack<string> myBook = new Stack<string>();
            myBook.Push("Tolstiy i tonciy(Tolstoy)");
            myBook.Push("Voina i mir(Tolstoy)");
            myBook.Push("Lev i sobaca(Tolstoy)");
            myBook.Push("U mory(Stivenking)");
            myBook.Push("yazikc#(Faskhutdinov)");

            string a = myBook.Pop();
            string b = myBook.Pop();
            string c = myBook.Pop();
            string d = myBook.Pop();
            string e = myBook.Pop();
            Console.WriteLine(a, b);





        }
    }
}








