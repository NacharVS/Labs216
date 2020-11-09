using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov.Delegates
{
    class BranchOffice
    {
        private delegate int[] Sort(int[] array);
        private delegate int Number(int[] array);

        public static void Run()
        {
            Sort sorter = GeneralOffice.SortMassive;
            Number number = GeneralOffice.MaxMassive;
            number += GeneralOffice.SummMassive;

            Random rnd = new Random();
            int[] array = new int[5];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = rnd.Next(1, 100);
            }

            sorter(array);
            number(array);
        }
    }
}
