using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Delegates;
using Labs216.Nabiullina;

namespace Labs216
{
    class Program
    {
       
        static void Main(string[] args)
        {
            BANK acc = new BANK("Zul", "Nabiul", 17, 100);
            acc.Rate += Message;
            acc.ChangeRate(5);

            void Message(double stavka)
            {
                Console.WriteLine($"Rate change on {stavka}");
            }

        }

    }
}
