using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Strategy.Army
{
    public class Archer : Characteristics, IShootable, IMovable
    {
        public int Speed { get; private set; }        
        public int ShootDamage { get; private set; }
        public Archer (int health, int speed, int shootdamage)
        {
            Health = health;
            Speed = speed;
            ShootDamage = shootdamage;
        }
    }
}
