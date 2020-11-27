using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.workers
{
    class fisher : Characteristicsworkers, Iworkers 
    {
        public fisher(int health, int dengi)
        {
            _health = health;
            _dengi = dengi;
        }

        public void Cook()
        {
            Console.WriteLine("Fisher cooking");
        }

        public void Eat()
        {
            Console.WriteLine("Fisher eating");
        }

        public void Move()
        {
            Console.WriteLine("Fisher moving");
        }

        public void Sleep()
        {
            Console.WriteLine("Fisher sleeping");
        }
    }
}
