﻿using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Delegates;
using Labs216.Nabiullina;
using Labs216.Nabiullina.StrategyGame;

namespace Labs216
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //BANK acc = new BANK("Zul", "Nabiul", 17, 2500);
            //acc.Rate += Message;
            //acc.ChangeRate(5);

            //void Message(double stavka)
            //{
            //    Console.WriteLine($"Rate change on {stavka}");
            //}
            //acc.Pokypka(200);
            //acc.Partners(1);

            Doctor doctor = new Doctor(1,2,3);
            doctor.Movement();
            
        }

    }
}
