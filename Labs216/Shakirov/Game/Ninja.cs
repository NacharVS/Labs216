using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov.Game.Fighter
{
    class Ninja : Characteristic, IAttack, IMovable 
    {
        
        public double Speed { get; private set; }
        public double Damage { get; private set; }
        public int ShootDamage { get; private set; }
        public Ninja(int health, int defense, double speed, int damage, int distance, int shootdamage)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
            Damage = damage;
            ShootDamage = shootdamage;
        }
    }
}
