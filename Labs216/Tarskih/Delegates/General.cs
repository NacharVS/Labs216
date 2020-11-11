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
        static public void TheSumOfMassive(int[] massive, int[] massive_two)
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
            int s = 0;
            for (int i = 0; i < massive.Length; i = i + 1)
            {
                for (int j = 0; j < massive_two.Length; j = j + 1)
                {
                    if (i == j)
                    {
                        s = massive[i] + massive_two[j];
                    }
                }
            }
            Console.WriteLine($"Сумма двух данных массивов равна {s}");
        }
        static public void TheDifferenceOfTwoMassive(int[] massive, int[] massive_two)
        {
            int d1 = 0;
            for (int i = 0; i < massive.Length; i = i + 1)
            {
                for (int j = 0; j < massive_two.Length; j = j + 1)
                {
                    if (i == j)
                    {
                        d1 = massive[i] - massive_two[j];
                    }
                }
            }
            Console.WriteLine($"Разность двух данных массивов равна {d1}");
        }
        static public void TheMultiplicationOfTwoMassives(int[] massive, int[] massive_two)
        {
            int m = 0;
            for (int i = 0; i < massive.Length; i = i + 1)
            {
                for (int j = 0; j < massive_two.Length; j = j + 1)
                {
                    if (i == j)
                    {
                        m = massive[i] * massive_two[j];
                    }
                }
            }
            Console.WriteLine($"Произведение двух данных массивов равно {m}");
        }
        static public void TheDivisionOfTwoMassives(int[] massive, int[] massive_two)
        {
            int d2 = 0;
            for (int i = 0; i < massive.Length; i = i + 1)
            {
                for (int j = 0; j < massive_two.Length; j = j + 1)
                {
                    if (i == j)
                    {
                        d2 = massive[i] / massive_two[j];
                    }
                }
            }
            Console.WriteLine($"Деление двух данных массивов равно {d2}");
            Console.WriteLine("Все операции с массивами были выполнены");
        }
    }
}