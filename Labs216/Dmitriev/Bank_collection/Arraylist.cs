using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev.Bank_collection
{
    class Arraylist
    {
        public void Collection()
        {
            Arraylist list = new Arraylist();
            Arraylist listo4ekdouble = new Arraylist();
            Arraylist listo4ekint = new Arraylist();
            Arraylist listo4ekstring = new Arraylist();
            List.Add(135);
            List.Add(531);
            List.Add(2.5);
            List.Add(5.0);
            List.Add("string");//stroka
            List.Add("privet");
            List.Add("test");
            List.Add(579);
            List.Add(3.5);
            List.Add(8.1);
            List.Add(1);
            List.Add(2);
            List.Add(3);
            List.Add("dosvidanie");//END,BYE
            List.Add("privet");
            foreach (var item in List)
            {
                if ("System.Int32" == item.GetType().ToString())
                {
                    listo4ekint.Add(item);
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();
            foreach (var item in List)
            {
                if ("System.String" == item.GetType().ToString())
                {
                    listo4ekstring.Add(item);
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();
            foreach (var item in List)
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
