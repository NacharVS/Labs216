using System;
using System.Linq;
using Labs216.Anisimov;

namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            BankEmployee client = new BankEmployee("qwe", "asd", "zxc", "12 year", 10000);
            client.GetInfo();
        }
    }
}
