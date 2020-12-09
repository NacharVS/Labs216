using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labs216
{
    class ArrayList1
    {
        public void ArrayL()

        {
            ArrayList array = new ArrayList();
            ArrayList arrayOfInt = new ArrayList();
            ArrayList arrayofstring = new ArrayList();
            ArrayList arrayofDouble = new ArrayList();
            array.Add("Timur");
            array.Add(24);
            array.Add(3.13);
            array.Add("T");
            array.Add(26);
            array.Add(2.13);
            array.Add("апвпа");
            array.Add(26);
            array.Add("lflff");
            array.Add(6.15);


            foreach (var item in array)
            {
                if (item.GetType() == typeof(int))
                {
                    arrayOfInt.Add(item);
                }

                if (item.GetType() == typeof(string))
                {
                    arrayofstring.Add(item);
                }
                if (item.GetType() == typeof(double))
                {
                    arrayofDouble.Add(item);
                }
            }




        }
    }
}
