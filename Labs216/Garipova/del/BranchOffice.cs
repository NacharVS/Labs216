using System;


namespace Labs216.Garipova.del
{
    class BranchOffice
    {
        delegate void Massif(int[] array);  

        public static void Invocation(int[] array)
        {
            Massif mss = null;
            mss += GeneralOffice.Maxx;
            mss += GeneralOffice.Summa;
            mss += GeneralOffice.Sorterovka;
            
        }
    }
}
