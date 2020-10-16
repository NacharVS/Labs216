using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.GaraevaAF
{
    class Volume_parallelepiped_s
    {
        static public void Volume_parallepiped_s1()
        {
            Console.WriteLine("Enter the length");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height");
            int h = int.Parse(Console.ReadLine());
            int v = 0;
            {
                if (a > 0)
                {
                    v = a * b * h;
                    Console.WriteLine($"{v} = {a} * {b} * {h}");
                }
            }
        }
    }
}
