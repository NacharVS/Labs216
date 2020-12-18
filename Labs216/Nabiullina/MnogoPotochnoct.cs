using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Labs216.Nabiullina
{
    class MnogoPotochnoct
    {

        public static void Thread1()
        {
            Console.WriteLine("1 massiv");
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(10, 100);
                Console.WriteLine(array[i]);
            }
        }
        public static void Thread2()
        {
            Console.WriteLine("2 massiv");
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(10, 100);
                Console.WriteLine(array[i]);
            }
        }
        public static void Thread3()
        {
            Console.WriteLine("Summ massiv");
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
            }
        }
        public static void Thread4()
        {
           
        }
    }

}
// есть 2 массива, одномерн., заполнить тут же их сложить, сложение чуть позже\отсортировать после суммы, как хочу\ заполнять параллельно\