using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev
{

    class numeratsiyaknig
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);
            numbers.Enqueue(5);
            int queueElement = numbers.Dequeue();
            Console.WriteLine(queueElement);
            Queue<book> books = new Queue<book>();
            books.Enqueue(new book() { Name = "naruto,Kishimoto Masashi,1999" });
            books.Enqueue(new book() { Name = "ataka titanov,Xadzime Isayami,2009" });
            books.Enqueue(new book() { Name = "7 smertnblx grexov,Nakaba Sudzuki 2012" });
            books.Enqueue(new book() { Name = "xunter x xunter,1998" });
            books.Enqueue(new book() { Name = "Klinok, cleaves demon,Kimetsu no Yaiba,2015" });
            book pp = books.Peek();
            Console.WriteLine(pp.Name);
            Console.WriteLine("сейчас в очереди{0} kniga", books.Count);
            foreach (book p in books)
            {
                Console.WriteLine(p.Name);
            }
            book book = books.Dequeue();
            Console.WriteLine(book.Name);
            Console.ReadLine();
        }
    }
    class book
    {
        public string Name { get; set; }
    }
}
    
