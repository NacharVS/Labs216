using System;


namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[10];
            Random rnd = new Random();

            for (int x = 0; x > Array.Length; x++)
            {
                Array[x] = rnd.Next(50);
                Console.WriteLine(+ x + " = "+ Array[x]);
            }

        }
    }
}
