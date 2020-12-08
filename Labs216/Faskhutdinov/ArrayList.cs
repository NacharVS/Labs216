using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Faskhutdinov
{
    class PracticArrayList
    {
        public static void ListSert();
       }
       ArrayList List = new ArrayList() { -23, "54", 1.7, "30", -24, 2.5, 25, 26, "12", "43", 4 , "21", 4.3, 3.4, 5.5 };
       private ArrayList StringList = new ArrayList();
       private ArrayList DoubleList = new ArrayList();
       private ArrayList IntList = new ArrayList();
         foreach(var item in List)
            {
                switch (item.GetType().ToString())
                {
                    case "System.String":
                        StringList.Add(item);
                        break;
                    case "System.Double":
                        DoubleList.Add(item);
                        break;
                    case "System.Int32":
                        IntList.Add(item);
                        break;
                }
            }


        