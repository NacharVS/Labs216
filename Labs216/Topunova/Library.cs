using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Topunova
{
    class Library
    {
        public string _book;
        public string _writer;
        public string _year;

        public Library(string book, string writer, int year)

        {
            _book = book;
            _writer = writer;
            _year = year;
        }
        public static void Stack()
        {
            Stack<int> books = new Stack<int>();
            books.Push("The maze runner", "James Dashner", "2009");
            books.Push("Harry Potter", "Joanne Rowling", "1997");
            books.Push("Мертвые души", "Николай Гоголь", "1842");
            books.Push("Собака Баскервилей", "Артур Конан Доил", "1901");
            books.Push("После", "Анна Тод", "2014");

            books.Pop();
            {
                Console.WriteLine();
                Console.WriteLine($"_books", "_writer", "_year");
            }
        }

    }
}
