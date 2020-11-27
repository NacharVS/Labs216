using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov.Game
{
    sealed class Medic : Characteristic, IMovable, IGather
    {
        public double Speed { get; private set; }
        public int Amount { get; set; }

        public Medic(int health, int defense, double speed)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
        }

        public void Gather(IResourseSourse source)
        {
            if (source.Amount == 0)
            {
                Console.WriteLine("Sourse if empty");
                return;
            }
            if (source.Amount >= 100)
            {
                Amount += 100;
                source.Amount -= 100;
            }
            else
            {
                Amount += source.Amount;
                source.Amount = 0;
            }

        }

        public void Store(IStorage storage)
        {
            if (Amount == 0)
            {
                Console.WriteLine("Gather don't have resourse");
                return;
            }
            storage.Food += Amount;
            Amount = 0;
        }
    }
}
