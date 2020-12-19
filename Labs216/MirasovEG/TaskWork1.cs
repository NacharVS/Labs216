using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Labs216.MirasovEG
{
    class TaskWork1
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];

            Task full = Task.Factory.StartNew(() => FullArray(array1, array2));
            full.Wait();
            

            Task sortSum = Task.Factory.StartNew(() => SortSumArray(array1, array2));
            sortSum.Wait();
            Console.WriteLine("Завершение метода Main");
        }


        public static void FullArray(int[] array1, int[] array2)
        {
            Random rnd = new Random();

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(0, 100);
                array2[i] = rnd.Next(0, 100);
            }
        }

        public static int[] SumArray(int[] array1, int[] array2)
        {
            int[] res = new int[10];

            for (int i = 0; i < array1.Length; i++)
            {
                res[i] = array1[i] + array2[i];
                Console.WriteLine($"Результат суммирования {i} элементов: {res[i]}");
            }
            return res;
        }

        public static void SortSumArray(int[] array1, int[] array2)
        {
            int[] sort = SumArray(array1, array2);
            Array.Sort(sort);
            Console.WriteLine("Сортировка суммы массивов");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{sort[i]}  ");
            }

            Console.WriteLine();
        }

    }
}
