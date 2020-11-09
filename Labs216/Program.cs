using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Delegates;
using Labs216.Nabiullina;

namespace Labs216
{
    class Program
    {
        private delegate void Massiv();
        static void Main(string[] args)
        {
            Massiv Mas;
            Mas = BranchOffice.Summmasiv;
            Mas();

        }
    }
}
