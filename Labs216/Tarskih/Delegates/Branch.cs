using System;
using System.Collections;

namespace Labs216.Tarskih.Delegates
{
    class Branch
    {
        private delegate void Massive();
        public static void Main()
        {
            int[] nums = new int[5];
            Console.WriteLine("Введите 5 чисел");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{0}-е число: ");
                nums[i] = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
