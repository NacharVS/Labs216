using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina
{
    class Book
    {
        public string _name;
        public string _avtop;
        public int _godizdaniya;

        public Book(string name, string avtop, int godizdaniya)
        {
            _name = name;
            _avtop = avtop;
            _godizdaniya = godizdaniya;
        }

        
        public static void SStack()
        {
            Stack<Book> knigi = new Stack<Book>();
            knigi.Push(new Book("Тёмная сторона", "Макс Фрай", 1997));
            knigi.Push(new Book("Ведьмак. Крещение огнем", "Сапровский Анджей", 1996));
            knigi.Push(new Book("Тысяча сияющих солнц", "Хоссейни Халед", 2008));
            knigi.Push(new Book("Бегущий за ветром", "Хоссейни Халед", 2003));
            knigi.Push(new Book("Буря мечей", "Мартин Джордж", 2000));

            knigi.Pop();
            knigi.Push(new Book("Ололол", "Мартин Джордж", 2000));

            foreach (var item in knigi)
            {
                Console.WriteLine($"Книга: {item._name}. Автор: {item._avtop}. Год издания: {item._godizdaniya}");
            }
        }
    }

}
