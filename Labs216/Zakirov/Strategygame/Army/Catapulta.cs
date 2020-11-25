using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Strategygame.Army
{
   public class Catapulta : Characteristics, IMovable, IShootable
    {
        public int Speed { get; private set; }
        public int ShootDamage { get; private set; }
        public Catapulta(int health, int speed, int shootdamage)
        {
            Health = health;
            Speed = speed;
            ShootDamage = shootdamage;
        }
    }
}
