using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov
{
    class Book
    {
        public string name { get; private set; }
        public string autor { get; private set; }
        public int year { get; private set; }

        public Book(string name, string autor, int year)
        {
            this.name = name;
            this.autor = autor;
            this.year = year;
        }
    }

    public class RunBook
    {
        public static void Run()
        {
            Stack < Book > books = new Stack<Book>();
            bool alive = true;

            AddBook(books);

            while (alive)
            {
                try
                {
                    Console.WriteLine("1.Read book\t 2.View books\t 3.End");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            ReadBook(books);
                            break;
                        case "2":
                            ViewBooks(books);
                            break;
                        case "3":
                            alive = false;
                            continue;
                    }
                }
                catch (Exception exeption)
                {
                    var tmp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(exeption.Message);
                    Console.ForegroundColor = tmp;
                }
            }
        }

        private static void AddBook(Stack<Book> books)
        {
            books.Push(new Book("War and Peace", "Lev Tolstoy", 1869));
            books.Push(new Book("Hamlet", "William Shakespeare", 1609));
            books.Push(new Book("The Shining", "Stephen King", 1977));
            books.Push(new Book("Harry Potter and the Philosopher's Stone", "J. K. Rowling", 1997));
            books.Push(new Book("Crime and Punishment", "Fyodor Dostoevsky", 1866));
        }

        private static void ReadBook(Stack<Book> books)
        {
            var book = books.Pop();
            Console.WriteLine($"You reading a book\n{book.name}\n{book.autor}\n{book.year}\n");
        }

        private static void ViewBooks(Stack<Book> books)
        {
            foreach(Book item in books)
                Console.WriteLine($"You see a book\n{item.name}\n{item.autor}\n{item.year}\n");

        }
    }
}
