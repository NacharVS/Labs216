using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov
{
    class PracticArrayList
    {
        public static void ListSort()
        {
            ArrayList List = new ArrayList() { 1, "11", 1.1, 2, 3, 4, 5, "22", "33", "44", "55", 2.2, 3.3, 4.4, 5.5 };

            ArrayList IntList = new ArrayList();
            ArrayList StringList = new ArrayList();
            ArrayList DoubleList = new ArrayList();

            foreach(var item in List)
            {
                switch (item.GetType().ToString())
                {
                    case "System.Int32":
                        IntList.Add(item);
                        break;
                    case "System.String":
                        StringList.Add(item);
                        break;
                    case "System.Double":
                        DoubleList.Add(item);
                        break;
                }
            }

            Console.WriteLine("int");
            Console.WriteLine();
            
            foreach(var item in IntList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("string");
            Console.WriteLine();

            foreach (var item in StringList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("double");
            Console.WriteLine();

            foreach (var item in DoubleList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
