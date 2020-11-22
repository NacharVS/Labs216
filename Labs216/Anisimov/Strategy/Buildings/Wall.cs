using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov.Strategy.Buildings
{
    sealed class Wall : Characteristic, IInteractive
    {
        public int Distance { get; private set; }
        public int ShootDamage { get; private set; }

        public Wall(int health, int defense)
        {
            Health = health;
            Defense = defense;
        }
    }
}
