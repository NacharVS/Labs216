﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs216.Tarskih.Delegates
{
    class General
    {
        public static void SortingByAscending(int[] massive)
        {
            Array.Sort(massive);
            for (int i = 0; i < massive.Length; i++)
            {
                Console.WriteLine(massive[i] + " ");
            }
            Console.WriteLine("Сортировка массива по возрастанию выполнена");
        }
        static public void SumOfMassive(int[] massive)
        {
            int x = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                x += massive[i];
            }
            Console.WriteLine($"Сумма массива равна {x}")
        }
    }
}
