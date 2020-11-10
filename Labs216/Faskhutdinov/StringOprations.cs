using System;


namespace Labs216.Faskhutdinov

{
    class StringOprations
    { 
        public static void chototam()
        {
            Console.WriteLine("My life - me rules");
            string[] textMass;
            string text = Console.ReadLine();
            textMass = text.Split(' ');
            Console.WriteLine("number of worlds: ");
            Console.WriteLine(textMass.Length);
            Console.ReadLine();
        }
        public static void Palindrome(string s)
        {
            s = s.Replace(" ", "");
            int count = 0;
            for (int i = 0; i < s.Length; i++) ;
            {
                if (s[i] == s.Length[s.Length - 1 - i]) ;
                count += 1;
            }
            if (count == s.Length)
                Console.WriteLine("Это строка палиндром!");
            else
                Console.WriteLine("Это строка не палиндром!");
        }

    }
        

} 
