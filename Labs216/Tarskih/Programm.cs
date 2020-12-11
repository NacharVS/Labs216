using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Tarskih.Interfaces;
using Labs216.Tarskih.Abstract_Classes;
using Labs216.Tarskih.Entity;
using Labs216.Tarskih.Constructions;

namespace Labs216.Tarskih
{
    class Programm
    {
        public static void Main(string[] args)
        {
            Start start = new Start();
            start.StartStrategy();
        }
    }
}
