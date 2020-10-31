using System;
using System.Collections.Generic;
using System.Text;

using Labs216.Nabiullina;

namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {

            BANK account1 = new BANK("Ivan", "Ivanov", 1999 , 6.7 , 100);
            account1.SetId();
            account1.SetVozrast();

            account1.SetSchet();
            account1.SetStavka();

            
            




        }
    }
}
