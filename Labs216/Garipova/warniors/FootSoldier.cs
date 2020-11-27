using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.warniors
{
    class FootSoldier : Characteristicswarniors, Iwariors
    {
        public FootSoldier(int health, int uron)
        {
            _health = health;
            _uron = uron;
        }
        public void Axe()
        {
            Console.WriteLine("FootSoldier axe");
        }

        public void Grenade()
        {
            Console.WriteLine(" FootSoldier grenade");
        }

        public void Stun()
        {
            Console.WriteLine("FootSoldier stun");
        }
    }
}
