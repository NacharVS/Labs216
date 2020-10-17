using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev
{
    class StringOperation
    {
        public static void SOP()
        {
            Console.WriteLine("Введите слово");
            string slovo = Console.ReadLine();
            int kolvo = slovo.Length;
            for (int a = 0; a < kolvo; a = a + 1)
                string chetnie = slovo.Substring(a, 1);
            Console.WriteLine(chetnie);
        }
    }
}
