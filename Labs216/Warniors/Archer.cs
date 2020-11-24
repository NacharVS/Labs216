using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Warniors
{
    class Archer: Characteristics, IShootable, IMovable
    {
        public Archer(int health, int uron)
        {
            _health = health;
            _uron = uron;

        }
        public void Move()
        {
            Console.WriteLine("Archer moving");
        }

        public void Shoot()
        {
            Console.WriteLine("Archer shoot");
        }

    }
}
