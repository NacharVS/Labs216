using System;

namespace Labs216.Lab3
{
    class EvenandOdd
    {
        static public void EvenandOdd1()
        {
            int a = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;
            for (int i = a; i > 0;)
            {
                int buf = a % 10;
                if (buf % 2 == 0)
                    even = even + 1;
                else odd = odd + 1;
                a = a / 10;
                i = i / 10;
            }
            Console.WriteLine($"odd {odd} even {even}");
            Console.Read();
        }
    }
}
