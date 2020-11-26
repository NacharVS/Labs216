using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Strategy.Buildings
{
    class Tower : Characteristics, IShootable 
    {        
        public int ShootDamage { get; private set; }

        public Tower(int health, int shootdamage)
        {
            Health = health;            
            ShootDamage = shootdamage;
        }
    }
}
