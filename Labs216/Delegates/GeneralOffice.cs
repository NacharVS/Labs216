using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Delegates
{

    class GeneralOffice
    {
        private delegate void Massiv();
        public static void Massivs()
        {
            Massiv Mas = null;
            Mas += BranchOffice.Maxelement;
            Mas += BranchOffice.Povozrastanijy;
            Mas += BranchOffice.Summmasiv;
            Mas();
        }
    }
}
