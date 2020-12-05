using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labs216.MirasovEG
{
    class ArrayListTest
    {
        public void Collection()
        {
            ArrayList collection = new ArrayList();
            ArrayList listInt = new ArrayList();
            ArrayList listString = new ArrayList();
            ArrayList listDouble = new ArrayList();

            collection.Add(123);
            collection.Add(321);
            collection.Add(2.3);
            collection.Add(4.6);
            collection.Add("string");
            collection.Add("hello");
            collection.Add("test");
            collection.Add(567);
            collection.Add(3.7);
            collection.Add(9.1);
            collection.Add(1);
            collection.Add(2);
            collection.Add(3);
            collection.Add("bye");
            collection.Add("privet");

            foreach (var item in collection)
            {
                if ("System.Int32" == item.GetType().ToString())
                {
                    listInt.Add(item);
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();
            foreach (var item in collection)
            {
                if ("System.String" == item.GetType().ToString())
                {
                    listString.Add(item);
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();
            foreach (var item in collection)
            {
                if ("System.Double" == item.GetType().ToString())
                {
                    listDouble.Add(item);
                    Console.WriteLine(item);
                }
            }
        }


    }
}
