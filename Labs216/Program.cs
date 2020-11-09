using Labs216.MirasovEG;
using System;
using Labs216.MirasovEG.Delegates;


namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                int value = rnd.Next(0, 99);
                myArray[i] = value;
                Console.Write($"{myArray[i]}  ");
            }

            Console.WriteLine();

            BranchOffice.ArrayActions arrayActions;
            arrayActions = GeneralOffice.Summ;
            arrayActions += GeneralOffice.Max;
            arrayActions += GeneralOffice.Sort;

            arrayActions?.Invoke(myArray);

        }
    }
}
