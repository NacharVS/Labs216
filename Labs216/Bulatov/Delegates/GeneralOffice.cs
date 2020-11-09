using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Delegates
{
    class GeneralOffice
    {
        public static void SortingMassive(int[] array)
        {
            
        
                //// ввод чисел
                //int[] array = new int[7];
                //Console.WriteLine("Введите семь чисел");
                //for (int i = 0; i < array.Length; i++)
                //{
                //    Console.Write("{0}-е число: ", i + 1);
                //    array[i] = Int32.Parse(Console.ReadLine());
                //}

                // сортировка
                int buf;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array [i] > array [j])
                        {
                            buf = array [i];
                            array[i] = array[j];
                            array[j] = buf;
                        }
                    }
                }

                //// вывод
                //Console.WriteLine("Вывод отсортированного массива");
                //for (int i = 0; i < array.Length; i++)
                //{
                //    Console.WriteLine(array[i]);
                //}
                //Console.ReadLine();
        }
        
    

        public static void SummMassive()
        {

        }
        public static void max()
        {

            int[] ar = { 67, 34, 3, 8, 35, 23 };
            Array.Sort(ar);
            int maxValue = ar[ar.Length - 1];
        }
    }
}
