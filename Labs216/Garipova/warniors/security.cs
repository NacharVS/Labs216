using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.warniors
{
    class security : Characteristicswarniors, Iwariors
    {
        public security(int health, int uron)
        {
            _health = health;
            _uron = uron;
        }
        public void Axe()
        {
            Console.WriteLine("security axe");
        }

        public void Grenade()
        {
            Console.WriteLine("security grenade");
        }
        public void Stun()
        {
            Console.WriteLine("security stun");
        }
    }
}
