using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov.Game
{
    interface IMovable
   {
        public double Speed { get;  }
        public void Move()
        {
            Console.WriteLine($"Юниты двигаются со скоростью: {Speed}");
        }
    }

    interface IShootable
    {
        public int ShootDamage { get; }
        public int Distance { get; }

        public void Shoot()
        {
            Console.WriteLine($"Юнит стреляет на расстояние -- {Distance} -- с уроном: {ShootDamage}");
        }
    }

    interface IAttack
    {
        public int Damage { get; }
        public void Attack()
        {
            Console.WriteLine($"Юнит атакует на урон: {Damage}");
        }
    }

    interface IInteractive
    {
        public void Interact()
        {
            Console.WriteLine($"Здесь нет ничего интересного");
        }
    }

    interface IResourseSourse
    {
        public int Amount { get; set; }
    }

    interface IStorage
    {
        public int Diamond { get; set; }
        public int Wood { get; set; }
        public int Food { get; set; }
    }

    interface IGather : IResourseSourse
    {
        public void Gather(IResourseSourse sourse);
        public void Store(IStorage storage);
    }
}
