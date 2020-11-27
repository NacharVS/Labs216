using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.workers
{
    class Baker : Characteristicsworkers, Iworkers
    {

        public Baker(int health, int dengi)
        {
            _health = health;
            _dengi = dengi;
        }

        public void Cook()
        {
            Console.WriteLine("Baker cooking");
        }

        public void Eat()
        {
            Console.WriteLine("Baker eating");
        }

        public void Move()
        {
            Console.WriteLine("Baker moving");
        }

        public void Sleep()
        {
            Console.WriteLine("Baker sleeping");
       }

    }
}
