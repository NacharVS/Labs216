using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Delegates
{
    class GeneralOff
    {
        static public void SummTwoMassivs(int[] array)
        {
            
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
