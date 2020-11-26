using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Strategy
{
    public class Cavalry : Characteristics, IMovable, IAttack
    {
        public int Speed { get; private set; }
        public int Damage { get; private set; }
        public Cavalry(int health, int speed, int damage)
        {
            Health = health;
            Speed = speed;
            Damage = damage;
        }
    }
}
