using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dimukhametov.Books
{
    class Book
    {
        private string _BookName;
        private string _BookAuthor;
        private int _BookYear;

        public Book(string name, string author, int year)
        {
            _BookName = name;
            _BookAuthor = author;
            _BookYear = year;
        }
        public void Read()
        {
            Console.WriteLine($"Вы прочитали \n {_BookName}, {_BookAuthor}, {_BookYear}");
        }
    }
    class StackWork
    {
        public void Work()
        {
            Stack<Book> book = new Stack<Book>();

            book.Push(new Book("Математика", "В.В.Путин", 2000));
            book.Push(new Book("Литература", "Д.И.Медведев", 2008));
            book.Push(new Book("Татарский", "D.J.Trump", 2014));
            book.Push(new Book("Узбекский", "J.O,Biden", 2016));
            book.Push(new Book("Физкультура", "Л.В.Яшин", 2020));
        }
    }
}
