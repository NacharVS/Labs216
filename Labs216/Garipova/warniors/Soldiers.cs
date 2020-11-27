using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.warniors
{
    class Soldiers : Characteristicswarniors, Iwariors
    {
        public Soldiers(int health, int uron)
        {
            _health = health;
            _uron = uron;
        }
        public void Axe()
        {
            Console.WriteLine("soldiers axe");
        }

        public void Grenade()
        {
            Console.WriteLine("soldiers grenade");
        }
        public void Stun()
        {
            Console.WriteLine("soldiers stun");
        }
    }
}
