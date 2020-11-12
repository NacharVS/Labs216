using Labs216.Garipova;
using Labs216.Garipova.del;
using System;


namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankaccount acc1 = new Bankaccount(300, +78937589254);
            acc1.Notify += MessageSending1;
            acc1.Notify += MessageSending2;
            acc1.Deposit(50);
            acc1.Widtraw(50);
        }
        public static void MessageSending1(string phonenumber, int sum)
        {
            Console.WriteLine($"Message send at {phonenumber}");
        }
        public static void MessageSending2(string phonenumber, int sum)
        {
            Console.WriteLine($"Account value{sum}");
        }
    }
}
