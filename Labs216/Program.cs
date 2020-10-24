using System;
using System.Collections.Generic;
using System.Text;

using Labs216.Nabiullina;

namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            int sch = 0;
            Console.WriteLine($"On the account now: {sch}");
            Console.WriteLine(" 1. Withdraw money  \n 2. Put money");
            string b = Console.ReadLine();
            switch (b)
            {
                case "1":
                    Console.WriteLine("Max 200");
                    int with = int.Parse(Console.ReadLine());
                    if (with > 200)
                    {
                        Console.WriteLine("NOOOT!!!");
                    }
                    else
                    {
                        Console.WriteLine(sch - with);
                    }
                    break;
                case "2":
                    Console.WriteLine("Min 50");
                    int put = int.Parse(Console.ReadLine());
                    if (put < 50)
                    {
                        Console.WriteLine("NOOOT!!!");
                    }
                    else
                    {
                        Console.WriteLine(sch + put);
                    }
                    break;
            }


        }
    }
}
