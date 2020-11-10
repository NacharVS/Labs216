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
            mss(array);
        }

    }
        public delegate void Maassif(int[] masss, int[] masssss);

        public static void Invocation22(int[] masss, int[] masssss)
        {
            Maassif msss = GeneralOffice.SummaMassivov;
            msss += GeneralOffice.RaznostMassivov;
            msss += GeneralOffice.Multiplicationmassivs;

        }
    }
    }
}
