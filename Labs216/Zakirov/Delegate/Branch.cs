using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Delegate
{
    class Branch
    {
        public delegate void Ainur(int[] mass);
        public static void AinurInvoke(int[] mass)
        {
            Ainur a = General.MaxValue;
            a += General.Sorting;
            a += General.SummArray;
            a(mass);
        }
    }
}
