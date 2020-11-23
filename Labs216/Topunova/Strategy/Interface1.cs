using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Topunova.Strategy
{
    class Interface
    {
        Interface IMovable
    {
        public double Speed { get; }
        public Move()
        {
            Console.WriteLine($"Spead");
        }
    }
    }
    interface IShort
    {
        public int Shoot { get; }
        public void Shoot()
        {
            Console.WriteLine("Unit moves with takly");
        }
    }
}
