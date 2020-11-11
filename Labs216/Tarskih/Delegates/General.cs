using System;
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
            Console.WriteLine("Cортировка массива по возрастанию выполнена");
        }
        static public void SumOfMassive(int[] massive)
        {
            int x = 0;
            for (int i = 0; i < massive.Length; i = i + 1)
            {
                x += massive[i];
            }
            Console.WriteLine($"Сумма массива равна {x}");
        }
        static public void TheMaximumValueOfTheMassive(int[] massive)
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
    }
}