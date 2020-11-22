using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov.Strategy.Buildings
{
    sealed class Tower : Characteristic, IInteractive, IShootable
    {
        public int Distance { get; private set; }
        public int ShootDamage { get; private set; }

        public Tower(int health, int defense, int distance, int shootdamage)
        {
            Health = health;
            Defense = defense;
            Distance = distance;
            ShootDamage = shootdamage;
        }

        public void Interact(IShootable archer)
        {
            ShootDamage += archer.ShootDamage;
            Console.WriteLine($"Shootable unit move in the tower. Damage increace + {archer.ShootDamage} -- {ShootDamage}");
        }
    }
}
