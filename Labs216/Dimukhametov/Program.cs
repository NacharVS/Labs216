using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dimukhametov
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank account = new Bank(999, 0.05);
            account.Deposit(100);
            account.Withdraw(99);
            account.Deposit(500);
        }
        public static void Message(int sum, string phonenumber)
        {
            Console.WriteLine($"Message send at {phonenumber}");
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
