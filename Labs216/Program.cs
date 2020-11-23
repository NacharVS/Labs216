using System;
using Labs216.Zamaliev;
using Labs216.Zamaliev.StrategyGame;
using Labs216.Zamaliev.StrategyGame.Workers;

namespace Labs216
{
    class program
    {
        static void Main(string[] args)
        {
            Student std = new Student("asd", "dsa");
            Console.WriteLine(std.Firstname);
        }
        //private static void Message(string PhoneNumber, string message)
        //{
        //    Console.WriteLine($"Было отправлено сообщение на номер: {PhoneNumber}");
        //    Console.WriteLine($"Сообщение: {message}");
        //    Console.WriteLine();
        //}
    }
}
