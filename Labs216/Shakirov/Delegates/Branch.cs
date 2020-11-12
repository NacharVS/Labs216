using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov.Delegates
{
    class BranchOffice
    {
        public static void MaxValue()
        {
            Random rnd = new Random();
            int[] array = new int[23];
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(80);
                Console.Write($" {array[i]}");
                if (max < array[i])
                    max = array[i];
            }
            Console.WriteLine();
            Console.Write($"max: {max}");
        }
        }
    }


