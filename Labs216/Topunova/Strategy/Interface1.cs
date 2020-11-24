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
    interface IShoot
    {
        public int Shoot { get; }
        public void Shootable()
        {
            Console.WriteLine("Unit moves with takly");
        }
    }
}

