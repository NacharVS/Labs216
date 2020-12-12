using System;
using System.Collections.Generic;

namespace Labs216
{
    class Program
    {
        private static object BankList;

        static void Main(string[] args)
        {
            List<> BankList = new List<Bank>();
            BankList.Add(new Bank("Insaf", 14));
            BankList.Add(new Bank("Islam", 32));
            BankList.Add(new Bank("Ilnaz", 17));
            BankList.Add(new Bank("Anton", 19));
            BankList.Add(new Bank("Ilgz", 18));
            BankList.Add(new Bank("Indira", 11));
            foreach (Bank item in BankList)
            {

            }
            Console.WriteLine(item.Name);
        }
    }
}
