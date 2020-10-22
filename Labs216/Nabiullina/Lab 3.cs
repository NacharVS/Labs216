using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina
{
    class Lab_3
    {
        static public void Lab_3_1()
        {
            Console.Write ("Write something: ");
            string a = Console.ReadLine();
            string chet = null;
            string nechet = null;
                for ( int i =  0; i< a.Length; i++ )
                {
                    if (i % 2 == 0)
                    {
                    chet += a[i];
                    }
                    else
                    {
                    nechet += a[i];

                    }
                    
                }
            Console.WriteLine($" Even characters: {chet}");
            Console.WriteLine($" Odd characters: {nechet}");
        }

        static public void Lab_3_2()
        {
            Console.Write("Write something: ");

            if 
        }
    }
}
