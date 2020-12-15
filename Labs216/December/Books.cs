using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.December
{
    class Books
    {
        public string name;
        public string author;
        public int yearOfPublication;

        public Books(string Name, string Author, int YearOfPublication)
        {
            name = Name;
            author = Author;
            yearOfPublication = YearOfPublication;
        }
    }
    class Library
    {
        public static void Book()
        {
            Stack<Books> books = new Stack<Books>();
            books.Push(new Books("Куриный бульон", "Марк Виктор Хансен", 1993));
            books.Push(new Books("Сумерки", "Стефани Майер", 2005));
            books.Push(new Books("Гарри Потер", "Джоан Роулинг", 1997));
            books.Push(new Books("Виноваты звезды", "Джон Грин", 2015));
            books.Push(new Books("Титаник", "Уолтер Лорд", 2012));

            books.Peek();
            books.Pop();
            Console.WriteLine("Other books:");
            foreach (var item in books)
            {
                Console.WriteLine($"{item.name} {item.author} {item.yearOfPublication}");
            }
        }
    }
}
