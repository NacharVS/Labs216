using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.warniors
{
    class ninja : Characteristicswarniors, Iwariors
    {
        public ninja(int health, int uron)
        {
            _health = health;
            _uron = uron;
        }
        public void Axe()
        {
            Console.WriteLine("ninjia axe");
        }

        public void Grenade()
        {
            Console.WriteLine("ninjia grenade");
        }
        public void Stun()
        {
            Console.WriteLine("ninjia stun");
        }
    }
}
