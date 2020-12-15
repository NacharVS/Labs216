using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zamaliev
{
    class QueueAndStack
    {
       public static void Reading()
        {
            Queue<string> Books = new Queue<string>();

            Books.Enqueue("Михаил Булгаков — Мастер и Маргарита,1940");
            Books.Enqueue("Николай Гоголь — Мёртвые души,1842");
            Books.Enqueue("Михаил Булгаков — Собачье сердце,1925");
            Books.Enqueue("Федор Достоевский — Преступление и наказание,1866");
            Books.Enqueue("Лев Толстой — Война и мир,1868");
            
            foreach(string item in Books)
            {
                Console.WriteLine(item);
            }
        }
    }
}
