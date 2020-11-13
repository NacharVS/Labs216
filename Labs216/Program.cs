using System;
using System.Linq;
using Labs216.Bulatov;
using Labs216.Bulatov.Delegates;


namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {


            static void Message(string PhoneNumber, string message)
            {
                Console.WriteLine($"Было отправлено сообщение на номер: {PhoneNumber}");
                Console.WriteLine($"Сообщение: {message}");
                Console.WriteLine();
            }
        }
    }
}

