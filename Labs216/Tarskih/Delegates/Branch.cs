using System;
using System.Collections;

namespace Labs216.Tarskih.Delegates
{
    class Branch
    {
        private delegate void Massive (int[] massive);
        public static void Imya()
        {
            int[] massive = { 228, 69, 1337, 18, 23 };
            Massive massive1 = General.SortingByAscending;
            massive1(massive);
        }
    }
}
