using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev
{
    class StringOperation
    {
        public static void SOP()
        {
            string a = Console.ReadLine();
            string c = a;
            for (int g = 0; g < a.Length; g++)
                a = a.Remove(g, 1);
            Console.WriteLine(a);
            for (int f = 1; f < c.Length; f++)
                c = c.Remove(f, 1);
            Console.WriteLine(c);
        }
    }
}
