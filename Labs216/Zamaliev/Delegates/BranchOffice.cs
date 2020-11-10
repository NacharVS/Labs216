using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zamaliev.Delegates
{
    class BranchOffice
    {
        public delegate void Robert(int[] mass);
        public static void RobertInvoke(int[] mass)
        {
            Robert a = GeneralOffice.Sort;
            a += GeneralOffice.Sum;
            a += GeneralOffice.Max;
            a(mass);
        }
    }
}
