using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Warniors
{
    class Archer: Characteristics, IShootable, IMovable, IBlind, IFight, IAttack
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
        public void Attack()
        {
            Console.WriteLine("Archer attacking");
        }
    }
}
