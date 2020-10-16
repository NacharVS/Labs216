using Labs216.MikhalevVL;
using System;

namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
           
                LetterFix[] student = new LetterFix[5];
                for (int i = 0; i < 5; i++)
                {
                    student[i] = new LetterFix();

                    Console.WriteLine("Enter Name:");
                    student[i].Name = Console.ReadLine();

                    Console.WriteLine("Enter Surname:");
                    student[i].Surname = Console.ReadLine();
                }

                Console.WriteLine();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Student {i+1} -- {student[i].Name} {student[i].Surname}");
                }
            }
        }

    }
