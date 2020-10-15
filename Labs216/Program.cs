using Labs216.MirasovEG;
using System;

namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            LetterFix[] std = new LetterFix[5];
            for (int i = 0; i < 5; i++)
            {
                std[i] = new LetterFix();

                Console.WriteLine("Enter Name:");
                std[i].Name = Console.ReadLine();

                Console.WriteLine("Enter Surname:");
                std[i].Surname = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Student number {i+1}: {std[i].Name} | {std[i].Surname}");
            }
        }
    }
}
