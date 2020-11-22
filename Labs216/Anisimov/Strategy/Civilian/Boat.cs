using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov.Strategy.Civilian
{
    sealed class Boat : Characteristic, IMovable
    {
        public double Speed { get; private set; }

        public Boat(int health, int defense, double speed)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
        }
    }
}
