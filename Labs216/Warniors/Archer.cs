using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Warniors
{
    class Archer: Characteristics, IArcher
    {
        public Archer(int health, int uron, int force, int adroitness, int attention, int malice)
        {
            _health = health;
            _uron = uron;
            _force = force;
            _adroitnes = adroitness;
            _attention = attention;
            _malice = malice;
        }
        public void Move()
        {
            Console.WriteLine("Archer moving");
        }

        public void Shoot()
        {
            Console.WriteLine("Archer shooting");
        }
        public void Blind()
        {
            Console.WriteLine("Archer blinding");
        }
        public void Fight()
        {
            Console.WriteLine("Archer fighting");
        }
        
    }
}
