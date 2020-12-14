using System;
using Labs216.Zamaliev;


namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank Ivana = new Bank(0, 0.5, "88005553535");
            Ivana.Notify += Message;
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Ivana.Deposit(int.Parse(Console.ReadLine()));
                        break;
                    case "2":
                        Ivana.Snyat(int.Parse(Console.ReadLine()));
                        break;
                    default:
                        Console.WriteLine("vi razvalili sssr");
                        break;
                }
                Console.WriteLine($"Баланс: {Ivana.Balans}");
            }          
        }
        public static void Message(int sum, string phonenumber)
        {
            Console.WriteLine($"Message send at {phonenumber}. {sum}");
        }
        public static void Message2(int sum, string phonenumber)
        {
            Console.WriteLine($"Account value {sum}");
        }
        public static void Message3(double stavka)
        {
            Console.WriteLine($"Our stavka {stavka}");
        }
        public static void Message4(int sum, double cashback)
        {
            Console.WriteLine($"Return of a part of funds: {cashback}");
        }
    }
}

