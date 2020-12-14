using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dimukhametov.Dictionary
{
    public class MyBestWork
    {
            Dictionary<Guid, string> studentlist = new Dictionary<Guid, string>();
        public void DictionaryFill()
        {
            for (int i = 0; i <= 9; i++)
            {
                studentlist.Add(Guid.NewGuid(), Console.ReadLine());
            }
            Console.WriteLine();

            foreach (KeyValuePair<Guid, string> people in studentlist)
            {
                Console.WriteLine(people.Key + " - " + people.Value);
            }
        }
}   }
