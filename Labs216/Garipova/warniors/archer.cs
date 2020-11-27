using System;
namespace Labs216.Garipova.warniors
{
    class Archer : Characteristicswarniors, Iwariors
    {
        public Archer(int health, int uron)
        {
            _health = health;
            _uron = uron;
        }
        public void Axe()
        {
            Console.WriteLine("Archer axe");
        }

        public void Grenade()
        {
            Console.WriteLine("Archer grenade");
        }

        public void Stun()
        {
            Console.WriteLine("Archer stun");
        }
    }














}
