using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov.Strategy.Buildings
{
    sealed class Gate : Characteristic, IInteractive
    {
        public Gate(int health, int defense)
        {
            Health = health;
            Defense = defense;
        }

        public void Interact()
        {
            Console.WriteLine($"Move through the gate");
        }
    }
}
