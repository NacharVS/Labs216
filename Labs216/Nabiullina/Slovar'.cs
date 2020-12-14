using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina
{
    class Slovar_
    {
        public static void Slovarik()
        {
            Dictionary<int, string> personList = new Dictionary<int, string>();

            Random rnd = new Random();


            for (int i = 0; i<10;i++)
            {
                string name = Console.ReadLine();
                personList.Add(rnd.Next(0, 5000), name);
                
            }

            

            foreach (KeyValuePair <int, string> item in personList)
            {
                Console.WriteLine(item.Key +" "+ item.Value);
            }
            
        }
    }
}
