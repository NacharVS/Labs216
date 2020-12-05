using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Labs216.Nabiullina
{
    class ArrayList1
    {
        public static void Collection()
        {
            ArrayList Collect = new ArrayList();
            var listArrayInt = new ArrayList();
            var listArrayString = new ArrayList();
            var listArrayDouble = new ArrayList();
            Collect.Add("Tim");
            Collect.Add(15);
            Collect.Add(3.14);
            Collect.Add("Zulfiya");
            Collect.Add(23);
            Collect.Add(2.12);
            Collect.Add("Rabbit");
            Collect.Add(45);
            Collect.Add(5.16);
            Collect.Add("Mouse");
            Collect.Add(24);
            Collect.Add(23.23);
            Collect.Add("Home");
            Collect.Add(67);
            Collect.Add(45.2);
            foreach (var item in Collect)
            {
                if (item.GetType() == typeof(int))
                {
                    listArrayInt.Add(item);
                }
                else if (item.GetType() == typeof(string))
                {
                    listArrayString.Add(item);
                }
                else if (item.GetType() == typeof(double))
                {
                    listArrayDouble.Add(item);
                }
            }
            foreach (var item in listArrayString)
            {
                Console.Write($"{item}, ");
            }
            
        }

    }
}
