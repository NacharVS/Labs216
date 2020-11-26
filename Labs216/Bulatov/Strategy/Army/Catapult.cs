using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Strategy.Army
{
    public class Catapult : Characteristics, IMovable, IShootable
    {
        public int Speed { get; private set; }
        public int ShootDamage { get; private set; }
        public Catapult(int health, int speed, int shootdamage)
        {
            Health = health;
            Speed = speed;
            ShootDamage = shootdamage;
        }
    }
}
