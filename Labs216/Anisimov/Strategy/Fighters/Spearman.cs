using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov.Strategy.Fighters
{
    sealed class Spearman : Characteristic, IAttack, IMovable
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }

        public Spearman(int health, int defense, double speed, int damage)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
            Damage = damage;
        }
    }
}
