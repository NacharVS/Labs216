using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Delegates
{
    class BranchOffice
    {
        public delegate void Rabbit(int[] mass);
        public static void RabbitInvoke(int[] mass)
        {
            Rabbit rabbit = GeneralOffice.MaxValue;
            rabbit += GeneralOffice.Sorting;
            rabbit += GeneralOffice.SummArray;
            rabbit(mass);
        }
    }
}
