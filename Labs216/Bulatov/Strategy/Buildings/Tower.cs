using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Strategy.Buildings
{
    class Tower : Characteristics, IShootable, IInteract
    {        
        public int ShootDamage { get; private set; }

        public Tower(int health, int shootdamage)
        {
            Health = health;            
            ShootDamage = shootdamage;
        }
        public void Interact(IShootable archer)
        {
            ShootDamage += archer.ShootDamage;
            Console.WriteLine($"Shootable unit move in the tower. Damage increace -- {archer.ShootDamage} + {ShootDamage}");
        }
    }
}
