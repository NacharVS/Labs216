﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Strategygame
{
   public class Knight : Characteristics, IMovable, IAttack
    {
        public int Speed { get; private set; }
        public int Damage { get; private set; }
        public Knight(int health, int speed, int damage)
        {
            Health = health;
            Speed = speed;
            Damage = damage;
        }

    }
}
