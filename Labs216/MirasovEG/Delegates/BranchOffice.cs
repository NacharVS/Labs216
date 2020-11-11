

namespace Labs216.MirasovEG.Delegates
{
    class BranchOffice
    { 
        public delegate void ArrayActions(int[] myArray);
        public delegate void SecondArrayActions(int[] myArrayOne, int[] maArrayTwo);

        //int[] myArray = new int[10];
        //Random rnd = new Random();

        //    for (int i = 0; i<myArray.Length; i++)
        //{
        //    int value = rnd.Next(0, 99);
        //    myArray[i] = value;
        //    Console.Write($"{myArray[i]}  ");
        //}

        //Console.WriteLine();
        //Console.ForegroundColor = ConsoleColor.Red;
        //int[] myArrayOne = new int[10];

        //    for (int j = 0; j<myArrayOne.Length; j++)
        //{
        //    int value = rnd.Next(0, 99);
        //    myArrayOne[j] = value;
        //    Console.Write($"{myArrayOne[j]}  ");
        //}

        //Console.WriteLine();
        //int[] myArrayTwo = new int[10];

        //    for (int j = 0; j < myArrayTwo.Length; j++)
        //{
        //    int value = rnd.Next(0, 99);
        //    myArrayTwo[j] = value;
        //    Console.Write($"{myArrayTwo[j]}  ");
        //}
        //Console.ResetColor();
        //Console.WriteLine();
        //Console.WriteLine();

        //BranchOffice.ArrayActions arrayActions;
        //arrayActions = GeneralOffice.Summ;
        //arrayActions += GeneralOffice.Max;
        //arrayActions += GeneralOffice.Sort;

        //arrayActions?.Invoke(myArray);

        //BranchOffice.SecondArrayActions secondArrayActions;
        //secondArrayActions = GeneralOffice.SecondActions;

        //Console.WriteLine();
        //secondArrayActions?.Invoke(myArrayOne, myArrayTwo);
    }
}
