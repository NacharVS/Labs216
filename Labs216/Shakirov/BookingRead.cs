using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Labs216.Shakirov
{
    class Book
    {
        private string _BookName;
        private string _BookYear;
        private string _BookAuthor;

        public Book(string name, string year, string author)
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

            book.Push(new Book("Властелин колец", "Джон Р. Р. Толкин", "1954"));
            book.Push(new Book("Гордость и предубеждение", "Джейн Остин", "1813"));
            book.Push(new Book("Темные начала", "Филип Пулман", "1995"));
            book.Push(new Book("Автостопом по галактике", "Дуглас Адамс", "1979"));
            book.Push(new Book("Гарри Поттер и Кубок огня", "Джоан Роулинг", "2000"));

        }
    }
}

