using Labs216.Delegates;
using Labs216.GaraevaAF;
using Labs216.Lab2;
using Labs216.Lab3;
using Labs216.Lab4;
using System;

namespace Labs216
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Bank account = new Bank(999, "+79872314564");
            
            account.Deposit(100);
            account.Withdraw(99);
            account.Deposit(500);
        }
        public static void Message(int sum, string phoneNumber)
        {
            Console.WriteLine($"Message send at {phoneNumber}");
        }
        public static void Message2(int sum, string phoneNumber)
        {
            Console.WriteLine($"Account value {sum}");
        }
        public static void Message3(double stavka)
        {
            Console.WriteLine($"");
        }
    }
}
