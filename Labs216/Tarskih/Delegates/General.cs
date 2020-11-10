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
            Console.WriteLine("Сортировка массива по возрастанию выполнена");
        }
    }
}
