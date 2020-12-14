using System;
using System.Collections.Generic;

namespace Labs216.Garipova
{
    class DictionaryWork
    {
        static public void Dictionary1()
        {
            Dictionary<int, string> studentList = new Dictionary<int, string>();
            Random rnd = new Random();

            for (int i = 0; i <10; i++)
            {
                string hunny = Console.ReadLine();
                studentList.Add(rnd.Next(1,200), hunny);
            }
             
            foreach (KeyValuePair<int, string> item in studentList)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);

            }
        }
        
        
    }
}
