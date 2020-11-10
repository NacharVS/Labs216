using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Delegates
{

    class BranchOff
    {
        private delegate void Massiv(int[] array);
        public static void Massivs(int[]mass)
        {

            Massiv Mas = null;
            Mas = GeneralOff.Maxelement;
            Mas += GeneralOff.Povozrastanijy;
            Mas += GeneralOff.Summmasiv;
            Mas(mass);
        }
    }
}
