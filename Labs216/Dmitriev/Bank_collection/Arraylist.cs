using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev.Bank_collection
{
    class Arraylist
    {
        public void Collection()
        {
            Arraylist collection = new Arraylist();
            Arraylist listo4ekdouble = new Arraylist();
            Arraylist listo4ekint = new Arraylist();
            Arraylist listo4ekstring = new Arraylist();
            collection.Add(135);
            collection.Add(531);
            collection.Add(2.5);
            collection.Add(5.0);
            collection.Add("string");//stroka
            collection.Add("privet");
            collection.Add("test");
            collection.Add(579);
            collection.Add(3.5);
            collection.Add(8.1);
            collection.Add(1);
            collection.Add(2);
            collection.Add(3);
            collection.Add("dosvidanie");//END,BYE
            collection.Add("privet");
            foreach (var item in collection)
            {
                if ("System.Int32" == item.GetType().ToString())
                {
                    listo4ekint.Add(item);
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();
            foreach (var item in collection)
            {
                if ("System.String" == item.GetType().ToString())
                {
                    listo4ekstring.Add(item);
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();
            foreach (var item in collection)
            {
                if ("System.Double" == item.GetType().ToString())
                {
                    listo4ekdouble.Add(item);
                    Console.WriteLine(item);
                }

            }
        }
    }
}
