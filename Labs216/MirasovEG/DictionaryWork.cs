using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.MirasovEG
{
    class DictionaryWork
    {

        Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();

        public void DictionaryFill()
        {

            for (int i = 0; i <= 9; i++)
            {
                dictionary.Add(Guid.NewGuid() , Console.ReadLine());
            }

            Console.WriteLine();

            foreach (KeyValuePair<Guid, string> people  in dictionary)
            {
                Console.WriteLine(people.Key + " - " + people.Value);
            }
        }
    }
}
