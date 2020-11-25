using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Strategygame.Army
{
   public class Spearman : Characteristics, IMovable, IAttack
    {
        public int Speed { get; private set; }
        public int Damage { get; private set; }
        public Spearman(int health, int speed, int damage)
        {
            Health = health;
            Speed = speed;
            Damage = damage;
        }

    }
}
