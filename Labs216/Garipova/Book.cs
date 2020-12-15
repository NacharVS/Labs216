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
            Stack <Book> numbers = new Stack<Book>();
            numbers.Push("Дети капитана Гранта", "Гранта Жюль Верн", "1867");
            numbers.Push("Джейн Эйр", "Шарлотта Бронте", "1847");
            numbers.Push("Поллианна", "Элинор Портер", "1913");
            numbers.Push("Человек, который смеётся", "Виктор Гюго", "1869");
            numbers.Push("Рубиновая книга", "Керстин Гир", "2009");
            numbers.Push("Энн из Зелёных Крыш", "Люси Мод Монтгомери", "1908");

            var Book = numbers.Peek();

            Console.WriteLine(Book);

            numbers.Pop();
            Console.WriteLine();
            Console.WriteLine("Rest elements");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
