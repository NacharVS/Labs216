using Labs216.MirasovEG;
using System;
using Labs216.MirasovEG.Delegates;
using Labs216.MirasovEG.Strategy;


namespace Labs216
{
    class Program
    {
        public static void Main(string[] args)
        { 
            Start start = new Start();
            start.StartStrategy();

        }
    }
}
