using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov
{
    class ArrayList
    {
        public void Collection()
        {
            ArrayList collection = new ArrayList();
            ArrayList listInt = new ArrayList();
            ArrayList listString = new ArrayList();
            ArrayList listDouble = new ArrayList();

            collection.Add(456);
            collection.Add(654);
            collection.Add(2.5);
            collection.Add(5.0);
            collection.Add("string");
            collection.Add("hello");
            collection.Add("test");
            collection.Add(789);
            collection.Add(6.8);
            collection.Add(9.1);
            collection.Add(1);
            collection.Add(2);
            collection.Add(3);
            collection.Add("poka");
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
