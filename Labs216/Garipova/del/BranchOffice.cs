using System;


namespace Labs216.Garipova.del
{
    class BranchOffice
    {
        delegate void Massif(int[] array);  

        public static void Invocation(int[] array)
        {
            //Massif mss = GeneralOffice.Maxx;
            Massif mss = GeneralOffice.Summa;
            mss += GeneralOffice.Sorterovka;
            mss(array);
        }
    }
}
