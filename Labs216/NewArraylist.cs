using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labs216
{
    class NewArraylist
    {
        public static void Collection()
        {
            ArrayList List = new ArrayList();
            ArrayList IntList = new ArrayList();
            ArrayList StringList = new ArrayList();
            ArrayList DoubleList = new ArrayList();

            List.Add("Life is good");
            List.Add(999);
            List.Add(14.45);
            List.Add(2.89);
            List.Add("Memories");
            List.Add(17);
            List.Add(16);
            List.Add("Let it snow");
            List.Add(56.99);
            List.Add(20);
            List.Add(4.9);
            List.Add("Get up!");
            List.Add(67.90);
            List.Add(56);
            List.Add("Never give up!");
            

            foreach (var item in List)
            {
                //if (item.GetType() == typeof(int))
                //{
                //    IntList.Add(item);
                //    Console.WriteLine(item);
                //}
                //else 
                if (item.GetType() == typeof(string))
                {
                    StringList.Add(item);
                    Console.WriteLine(item);
                }
                //if (item.GetType() == typeof(double))
                //{
                //    DoubleList.Add(item);
                //    Console.WriteLine(item);
                //}
            }
        }
    }
}
