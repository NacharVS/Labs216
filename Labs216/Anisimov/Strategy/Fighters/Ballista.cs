using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov.Strategy.Fighters
{
    sealed class Ballista : Characteristic, IMovable, IShootable
    {
        public double Speed { get; private set; }
        public int Distance { get; private set; }
        public int ShootDamage { get; private set; }

        public Ballista(int health, int defense, double speed, int distance, int shootdamage)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
            Distance = distance;
            ShootDamage = shootdamage;
        }
    }
}
