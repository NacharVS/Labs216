using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Delegates
{
    class GeneralOff
    {
        static public void SummTwoMassivs(int[] array, int[] aray)
        {
            Console.WriteLine($" Summa");
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for(int j=0; j<aray.Length;j++)
                {
                    if (i == j)
                    {
                        a= array[i] + aray[j];
                        Console.WriteLine(a);
                        
                    }
                    
                }
            }

        }
        static public void RaznostTwoMassivs(int[] array, int[] aray)
        {
            Console.WriteLine($" Raznost'");
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < aray.Length; j++)
                {
                    if (i == j)
                    {
                       a= array[i] - aray[j];
                        Console.WriteLine(a);

                    }

                }
            }

        }
        static public void ProizvedTwoMassivs(int[] array, int[] aray)
        {
            Console.WriteLine($" Proizvedenie ");
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < aray.Length; j++)
                {
                    if (i == j)
                    {
                        a = array[i] * aray[j];
                        Console.WriteLine(a);

                    }

                }
            }

        }

        static public void Povozrastanijy(int[] array)
        {
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine(array[i]+ " ");

            }
        }

        static public void Summmasiv(int[] array)
        {
            
            int a = 0;
           
            for (int i = 0; i < array.Length; i++)
            {
                a += array[i];
                

            }
            Console.WriteLine($"Summ: {a}");
        }
        
        static public void Maxelement(int[] array)
        {

            
            int a = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (a<array[i])
                {
                    a = array[i];
                }
            
            }
            Console.WriteLine($" Max: {a}");
        }
    }
}
