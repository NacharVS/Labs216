using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Delegates
{

    class BranchOff
    {
        private delegate void Massiv(int[] array, int[] aray);
        public static void Massivs( int[] array, int[] aray)
        {
            
            Massiv Mas = null;
            Mas = GeneralOff.SummTwoMassivs;
            Mas += GeneralOff.RaznostTwoMassivs;
            Mas += GeneralOff.ProizvedTwoMassivs;
            
            //Mas = GeneralOff.Maxelement;
            //Mas += GeneralOff.Povozrastanijy;
            //Mas += GeneralOff.Summmasiv;


            Mas(array, aray);
        }
    }
}
