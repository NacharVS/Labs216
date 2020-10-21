using System;


namespace Labs216.Garipova
{
    class StringOprations
    { 
        public static void evenodd(string s)
        {
            Console.WriteLine("My life - my rules");

            for (int i = 0; i < s.Length; i++) ;
            {
                if (s[i] != ' ')
                    continue;
                if (i % 2 == 0)
                    Console.WriteLine(s[i]);

            }
        }
        public static void chototam() { }
    }
        

} 
