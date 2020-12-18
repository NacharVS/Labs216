using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Delegates;
using Labs216.Nabiullina;
using Labs216.Nabiullina.StrategyGame;
using System.Threading;
using System.Threading.Tasks;

namespace Labs216
{
    class Program
    {
       
        static void Main(string[] args)
        {

            Task[] tasks1 = new Task[4]
            {
                new Task(()=> MnogoPotochnoct.Thread1()),
                new Task(()=> MnogoPotochnoct.Thread2()),
                new Task(()=> MnogoPotochnoct.Thread3()),
                new Task(()=> MnogoPotochnoct.Thread4())
            };
            foreach(var t in tasks1)
            {
                t.Start();
                Console.WriteLine(tasks1);
            }
        }
       
    }
}
