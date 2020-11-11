using System;
using System.Collections;

namespace Labs216.Tarskih.Delegates
{
    class Branch
    {
        private delegate void Massive (int[] massive, int[] massive_two);
        public static void Imya()
        {
            int[] massive = { 228, 69, 1337, 18, 23 };
            int[] massive_two = { 22, 02, 19, 89, 31 };
            Massive massive1 = General.SortingByAscending;
            massive1 += General.TheSumOfMassive;
            massive1 += General.TheMaximumValueOfTheMassive;
            massive1 += General.TheSumOfTwoMassives;
            massive1 += General.TheDifferenceOfTwoMassive;
            massive1 += General.TheMultiplicationOfTwoMassives;
            massive1 += General.TheDivisionOfTwoMassives;
            massive1(massive, massive_two);
        }
    }
}
