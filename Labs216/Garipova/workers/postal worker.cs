using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.workers
{
    class postal_worker : Characteristicsworkers, Iworkers 
    {
        public postal_worker(int health, int dengi)
        {
            _health = health;
            _dengi = dengi;
        }

        public void Cook()
        {
            Console.WriteLine("Postal worker cooking");
        }

        public void Eat()
        {
            Console.WriteLine("Postal worker eating");
        }

        public void Move()
        {
            Console.WriteLine("Postal worker moving");
        }

        public void Sleep()
        {
            Console.WriteLine("Postal worker sleeping");
        }
    }
}
