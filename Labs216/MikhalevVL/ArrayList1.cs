using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labs216.MikhalevVL
{
    class ArrayList1
    {
        public static void ArrayListMthd()
        {
            var listString = new ArrayList();
            var listInt = new ArrayList();
            var listDouble = new ArrayList();
            var list = new ArrayList();
            list.Add("fawefs");
            list.Add(123);
            list.Add(1.23);
            list.Add("fawefs");
            list.Add(123);
            list.Add(1.23);
            list.Add("fawefs");
            list.Add(123);
            list.Add(1.23);
            list.Add("fawefs");
            list.Add(123);
            list.Add(1.23);
            list.Add("fawefs");
            list.Add(123);
            list.Add(1.23);

            foreach (var item in list)
            {
                if (item.GetType() == typeof(int))
                {
                    listInt.Add(item);
                }
                else if (item.GetType() == typeof(string))
                {
                    listString.Add(item);
                }
                else if (item.GetType() == typeof(double))
                {
                    listDouble.Add(item);
                }
                else Console.WriteLine("Incorrect type");
            }

            Console.WriteLine($"{listInt.Count}, {listString.Count}, {listDouble.Count}");
        }
    }
}
