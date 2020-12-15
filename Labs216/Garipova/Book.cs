using System;
using System.Collections.Generic;

namespace Labs216.Garipova
{
    class Book
    {
        private static string _Avtor;
        private static string _Nazvanie;
        private static int _God;

        public Book(string avtor, string nazvanie, int god)
        {
            _Avtor = avtor;
            _Nazvanie = nazvanie;
            _God = god;
        }  
    }
    class Library
    {
        public static void Library1()
        {
            Stack <Book> book = new Stack<Book>();
            book.Push(new Book("Дети капитана Гранта", "Гранта Жюль Верн", 1867));
            book.Push(new Book("Джейн Эйр", "Шарлотта Бронте", 1847));
            book.Push(new Book("Поллианна", "Элинор Портер", 1913));
            book.Push(new Book("Человек, который смеётся", "Виктор Гюго", 1869));
            book.Push(new Book("Рубиновая книга", "Керстин Гир", 2009));
            book.Push(new Book("Энн из Зелёных Крыш", "Люси Мод Монтгомери", 1908));

            var Book = book.Peek();

            Console.WriteLine(Book);

            book.Pop();
            Console.WriteLine();
            Console.WriteLine("Rest elements");
            foreach (var item in book)
            {
                Console.WriteLine(item);
            }
        }
    }
}
