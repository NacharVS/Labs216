using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs216.Tarskih.Delegates
{
    class General
    {
        public static void SortingByAscending(int[] massive, int[] massive_two)
        {
            Array.Sort(massive);
            for (int i = 0; i < massive.Length; i++)
            {
                Console.WriteLine(massive[i] + " ");
            }
            Console.WriteLine("Cортировка массива по возрастанию выполнена");
        }
        static public void SumOfMassive(int[] massive, int[] massive_two)
        {
            int x = 0;
            for (int i = 0; i < massive.Length; i = i + 1)
            {
                x += massive[i];
            }
            Console.WriteLine($"Сумма массива равна {x}");
        }
        static public void TheMaximumValueOfTheMassive(int[] massive, int[] massive_two)
        {
            int y = 0;
            for (int i = 0; i < massive.Length; i = i + 1)
            { 
                if (y < massive[i])
                {
                    y = massive[i];
                }
            }
            Console.WriteLine($"Максимальное значение в данном массиве равно {y}");
        }
        static public void TheSumOfTwoMassives(int[] massive, int[] massive_two)
        {
            int z = 0;
            for (int i = 0; i < massive.Length; i = i + 1)
            {
                for (int j = 0; j < massive_two.Length; j = j + 1)
                {
                    if (i == j)
                    {
                        z = massive[i] + massive_two[j];
                        Console.WriteLine($"Сумма двух данных массивов равна {z}");
                    }
                }
            }
        }
    }
}