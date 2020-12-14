using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI
{
    class Books
    {
        public static void BookOfRead()
        {
            Stack<string> myBook = new Stack<string>();
            myBook.Push("Master and Margarita(Bulgakov)");
            myBook.Push("Tom  Soier(Tven)");
            myBook.Push("War and World(Tolstoy)");
            myBook.Push("Undergrowth(Fonvizin)");
            myBook.Push("Crime and Punishment(Dostoevskiy)");

            string a = myBook.Pop();
            string b = myBook.Pop();
            string c = myBook.Pop();
            string d = myBook.Pop();
            string e = myBook.Pop();
            Console.WriteLine(a,b);


            


        }
    }
}

          
                
            

        


        