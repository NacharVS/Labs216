using Labs216.Delegates;
using Labs216.GaraevaAF;
using Labs216.Lab2;
using Labs216.Lab3;
using Labs216.Lab4;
using Labs216.Warniors;
using Labs216.Workers;
using Labs216.Buildings;
using System.Collections;
using System.Collections.Generic;
using Labs216.December;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass1 = new int[10];
            Random rnd = new Random();
            int[] mass2 = new int[10];
            int Sum = 0;

            Console.WriteLine("First mass:");
            for (int i = 0; i < mass1.Length; i++)
            {
                mass1[i] = rnd.Next(10, 99);
                Console.Write($" {mass1[i]}");
            }
            Console.WriteLine();

            Console.WriteLine("Second mass:");
            for (int i = 0; i < mass2.Length; i++)
            {
                mass2[i] = rnd.Next(10, 99);
                Console.Write($" {mass2[i]}");
            }
            Console.WriteLine();

            Console.Write("SumTwoMass:");
            for (int s = 0; s < mass1.Length; s++)
            {
                if (mass1[s] > 0)
                    Sum = mass1[s] + mass2[s];
                Console.Write($" {Sum}");
            }
            Console.WriteLine();
        }

    }
}