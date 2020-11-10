﻿using System;
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
        public delegate void Yogurt(int[] mass1, int[] mass2);
        public static void YogurtInvoke(int[] mass1, int[] mass2)
        {
            Yogurt yogurt = GeneralOffice.SumtwoArrays;
            yogurt += GeneralOffice.DifferenceTwoArrays;
            yogurt += GeneralOffice.Multiplication;
            yogurt(mass1, mass2);
        }

    }
}
