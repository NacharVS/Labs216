using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Delegates
{
    class BranchOffice
    {
        static public void Povozrastanijy()
        {
            int[] array = new int[5];
            Random rnd = new Random();
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 10);
                
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]> array[i++])
                {
                    a = array[i];
                    array[i] = array[i++];
                    array[i++] = a;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine(array[i]+ " ");

            }
        }

        static public void Summmasiv()
        {

        }
        
        static public void Maxelement()
        {

        }
    }
}
