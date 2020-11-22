using System;

namespace Labs216.Anisimov.Strategy
{
    interface IMovable
    {
        public double Speed { get; }
        public void Move()
        {
            Console.WriteLine($"Unit move with speed: {Speed}");
        }
    }

    interface IShootable
    {
        public int ShootDamage { get; }
        public int Distance { get; }

        public void Shoot()
        {
            Console.WriteLine($"Unit shoot on distance -- {Distance} -- with damage: {ShootDamage}");
        }
    }
    
    interface IAttack
    {
        public int Damage { get; }
        public void Attack()
        {
            Console.WriteLine($"Unit attack with damage: {Damage}");
        }
    }

    interface IInteractive
    {
        public void Interact()
        {
            Console.WriteLine($"There is nothing interesting here");
        }
    }

    interface IResourseSourse
    {
        public int Amount { get; set; }
    }

    interface IStorage
    {
        public int Gold { get; set; }
        public int Wood { get; set; }
        public int Food { get; set; }
        public int MaxAmount { get; }
    }

    interface IGather : IResourseSourse
    {
        public void Gather(IResourseSourse source);
        public void Store(IStorage storage);
    }
}
