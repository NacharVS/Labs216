using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov.Game.Civilian
{
    class Fisherman
    {
        sealed class Fisherman : Characteristic, IMovable, IGather
        {
            public double Speed { get; private set; }
            public int Amount { get; private set; }

            public Fisherman(int health, int defense, double speed)
            {
                Health = health;
                defense = defense;
                Speed = speed;
            }

            public void Gather(IResourseSourse sourse)
            {
                if (sourse.Amount == 0)
                {
                    Console.WriteLine("Источник, если он пуст");
                    return;
                }
                if (sourse.Amount >=100)
                {
                    Amount += 100;
                    sourse.Amount -= 100;
                }
                else
                {
                    Amount += 100;
                    sourse.Amount = 0;
                }
            }

            public void Store(IStorage storage)
            {
                if (Amount == 0)
                {
                    Console.WriteLine("У нас нет ресурсов для этого.");
                    return;
                }
                storage.Food += Amount;
                Amount = 0;
            }
        }
    }
}
