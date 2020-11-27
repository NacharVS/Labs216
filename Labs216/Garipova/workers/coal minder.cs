using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.workers
{
    class Coalminder : Characteristicsworkers, Iworkers
    {
        public Coalminder(int health, int dengi)
        {
            _health = health;
            _dengi = dengi;
        }

        public void Cook()
        {
            Console.WriteLine("Coalminder cooking");
        }

        public void Eat()
        {
            Console.WriteLine("Coalminder eating");
        }

        public void Move()
        {
            Console.WriteLine("Coalminder moving");
        }

        public void Sleep()
        {
            Console.WriteLine("Coalminder sleeping");
        }
    }
}

