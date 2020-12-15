using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.December
{
    class DictionaryClass
    {
        static public void Working()
        {
            Dictionary<int, string> acclist = new Dictionary<int, string>();
            Random rnb = new Random();
            for (int i = 0; i < 10; i++)
            {
                string man = Console.ReadLine();
                acclist.Add(rnb.Next(1, 99), man);
            }
            foreach (KeyValuePair<int, string> item in acclist)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
