﻿using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Delegates;
using Labs216.Nabiullina;
using Labs216.Nabiullina.StrategyGame;
using System.Threading;
using System.Threading.Tasks;
using Labs216._2_семестр;

namespace Labs216
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
           

            Chelovec chelo = new Chelovec("Patrick", "Star", 10);
            Chelovec.MongoReplaceByName("Patrick", chelo).GetAwaiter().GetResult();
            //Chelovec chel = new Chelovec() ;
            ////MnogoPotochnoct.Prr();
            //.GetAwaiter().GetResult();

            //Task[] tasks1 = new Task[4]
            //{
            //    new Task(()=> MnogoPotochnoct.Thread1()),
            //    new Task(()=> MnogoPotochnoct.Thread2()),
            //    new Task(()=> MnogoPotochnoct.Thread3()),
            //    new Task(()=> MnogoPotochnoct.Thread4())
            //};
            //foreach(var t in tasks1)
            //{
            //    t.Start();
            //    Console.WriteLine(tasks1);
            //}
        }

    }
}
