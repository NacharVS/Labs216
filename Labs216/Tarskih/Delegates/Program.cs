using System;
using Labs216.Tarskih;
using Labs216.Tarskih.Delegates;

namespace Labs216
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] massive = { 228, 69, 1337, 18, 23 };
            int[] massive_two = { 22, 02, 19, 89, 31 };
            Branch.Massive(massive, massive_two);
        }
    }
}
