using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov.Game.Fighter
{
    sealed class Paladin : Characteristic, IAttack, IMovable, IShootable
    {
        public double Speed { get; private set; }
        public int Distance { get; private set; }
        public int ShootDamage { get; private set; }
        public Paladin(int health, int defense, double speed, int damage, int distance, int shootdamage)
        {
            Speed = speed;
            Damage = damage;
            ShootDamage = shootdamage;
        }



    }
}
