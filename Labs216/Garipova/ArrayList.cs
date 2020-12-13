using System;
using System.Collections;

namespace Labs216.Garipova
{
    class ArrayList1
    {
        public static void Collection()
        {
            {
                ArrayList Carrot = new ArrayList();

                Carrot.Add(3.12);             
                Carrot.Add("Garipowa");
                Carrot.Add(5);
                Carrot.Add(12);
                Carrot.Add("Salam");
                Carrot.Add(2020);
                Carrot.Add(16);
                Carrot.Add("Instagram");
                Carrot.Add(156);             
                Carrot.Add(4.45);
                Carrot.Add("Vkontakte");
                Carrot.Add(0.15);
                Carrot.Add("Renatovna");
                Carrot.Add(4.45);
                Carrot.Add(5.98);
                foreach(var item in Carrot)
                {
                    if (item.GetType() == typeof(int))
                    {
                        IntList.Add(item);
                        Console.WriteLine(item);
                    }
                }
            }
            
           
        }

       
    }
}
