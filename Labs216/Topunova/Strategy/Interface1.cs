using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Topunova.Strategy
{

    interface IMovable
    {
        public double Speed { get; }
        public void Move()
        {
            Console.WriteLine($"Spead");
        }
    }
    interface IShort
    {
        public int Shootdmg { get; }
        public void Shoot()
        {
            Console.WriteLine("Unit moves with takly");
        }
    }
}

