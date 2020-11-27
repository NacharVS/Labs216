using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov.Game.Fighter
{
    sealed class knight : Characteristic, IAttack, IMovable, IShootable
    {
        public int Damage { get, private set; }
        public double Speed { get; private set; }
        public int Distance { get; private set; }
        public int ShootDamage { get; private set; }
        public knight(int health, int defense, double speed, int damage, int distance, int shootdamage)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
            Damage = damage;
            ShootDamage = shootdamage;
        }



    }
}
