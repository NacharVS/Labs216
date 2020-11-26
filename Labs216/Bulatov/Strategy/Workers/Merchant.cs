using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Strategy
{
    public class Merchant : Characteristics, IMovable
    {
        public int Speed { get; private set; }
        public Merchant(int health, int speed)
        {
            Health = health;
            Speed = speed;

        }

    }
}
