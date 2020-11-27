﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Strategy.Workers
{
    public class lumberjack : Characteristics, IMovable, IGather
    {
        public int Amount { get; set; }
        public int Speed { get; private set; }
        public lumberjack(int health, int speed)
        {
            Health = health;
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

        public void Gather(object food)
        {
            throw new NotImplementedException();
        }
    }
}