using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labs216.MirasovEG
{
    class Book
    {
        private string _name;
        private string _autor;
        private int _year;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Autor
        {
            get => _autor;
            set => _autor = value;
        }
        public int Year
        {
            get => _year;
            set => _year = value;
        }

        public Book(string name, string autor, int year)
        {
            _name = name;
            _autor = autor;
            _year = year;
        }
        public void Read()
        {
            Console.WriteLine($"Вы прочитали \n {_name}, {_autor}, {_year}");
        }
    }

    class StackWork
    {
        public void Work()
        {
            Stack<Book> book = new Stack<Book>();

            book.Push(new Book("Хоббит", "Джон Р.Р. Толкин", 1937));
            book.Push(new Book("Властелин Колец", "Джон Р.Р. Толкин", 1948));
            book.Push(new Book("Гарри Поттер", "Дж. К. Роулинг.", 1997));
            book.Push(new Book("Зов Ктулху", "Г.Ф. Лавкрафта ", 1926));
            book.Push(new Book("Путешествие к центру Земли", " Жюль Верн", 1864));

            foreach (var item in book)
            {
                Console.WriteLine($"{item.Name} | {item.Autor} | {item.Year}");
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Book book1 = book.Pop();
                Console.WriteLine($"Вы прочитали \n {book1.Name} | {book1.Autor} | {book1.Year}");
                Thread.Sleep(1000);
                Console.WriteLine();
            }
        }


    }
}
