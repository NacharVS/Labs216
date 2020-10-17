using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev
{
    class Devisioninterval
    {
        static public void devisioninterval()
        {
            Console.WriteLine("Введите number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите start");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите end");
            int end = int.Parse(Console.ReadLine());
            for (int k = start; k <= end; k++) 
            {
                if (k == 0) continue;
                int devision = number / k;
                Console.WriteLine($"{number} /{k}={devision} ");



            }
        }
    }
}
