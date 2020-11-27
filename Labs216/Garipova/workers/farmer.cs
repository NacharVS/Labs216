using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.workers
{
    class farmer : Characteristicsworkers, Iworkers
    {
        public farmer(int health, int dengi)
        {
            _health = health;
            _dengi = dengi;
        }

        public void Cook()
        {
            Console.WriteLine("Farmer cooking");
        }

        public void Eat()
        {
            Console.WriteLine("Farmer eating");
        }

        public void Move()
        {
            Console.WriteLine("Farmer moving");
        }

        public void Sleep()
        {
            Console.WriteLine("Farmer sleeping");
        }
    }
}
