using System;


namespace Labs216.MirasovEG.Delegates
{
    class GeneralOffice
    {
        public static void Sort(int[] myArray)
        {
            Array.Sort(myArray);
            Console.Write("Сортировка массива №1:  ");
            for (int i = 0; i <= myArray.Length-1; i++)
            {
                Console.Write($"{myArray[i]}  ");
            }
            Console.WriteLine();
        }

        public static void Summ(int[] myArray)
        {

            int sum = 0;

            for (int i = 0; i <= myArray.Length-1; i++)
            {
                sum += myArray[i];
            }
            Console.WriteLine($"Сумма элементов массива №1: {sum}");
        }

        public static void Max(int[] myArray)
        {
            int buff = 0;

            for (int i = 0; i < myArray.Length-1; i++)
            {
                if (buff < myArray[i])
                {
                    buff = myArray[i];
                }
            }
            Console.WriteLine($"Максимальное значение массива №1: {buff}");
        }

        public static void SecondActions(int[] myArrayOne, int[]myArrayTwo)
        {
            int lenght;

            if (myArrayOne.Length > myArrayTwo.Length) lenght = myArrayOne.Length;
            else lenght = myArrayTwo.Length;

            Console.WriteLine("Сумма элементов двух массивов(red)");
            for (int i = 0; i < lenght; i++)
            {
                Console.Write($"{myArrayOne[i] + myArrayTwo[i]}  ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Разность элементов двух массивов(red)");
            for (int i = 0; i < lenght; i++)
            {
                Console.Write($"{myArrayOne[i] - myArrayTwo[i]}  ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Произведение элементов двух массивов(red)");
            for (int i = 0; i < lenght; i++)
            {
                Console.Write($"{myArrayOne[i] * myArrayTwo[i]}  ");
            }

            Console.WriteLine();
        }
    }
}
