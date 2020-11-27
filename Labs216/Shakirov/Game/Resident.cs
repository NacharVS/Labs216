using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov.Game.Civilian
{
    class Resident
    {
        sealed class Resident : Characteristic, IMovable
        {
            public double Speed { get; private set; }

            public Resident(int health, int defense, double speed)
            {
                Heath = health;
                Defense = defense;
                Speed = speed;
            }
        }
    }
}
