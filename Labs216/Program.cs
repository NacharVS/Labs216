using Labs216.MirasovEG;
using System;
using Labs216.MirasovEG.Delegates;


namespace Labs216
{
    class Program
    {
        public static void Main(string[] args)
        {
            Bank bank = new Bank();

            bank.Notify += RateMessage;
            bank.NewRate(5);

            void RateMessage(int rate)
            {
                Console.WriteLine($"Rate has changed to {rate}");
            }

            Bank.StartBank();

        }
    }
}
