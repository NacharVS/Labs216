using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Strategygame
{
    interface IMovable
    {
        public int Speed { get; }
        public void Move()
        {
            Console.WriteLine($"Unit move with speed: {Speed}");
        }
    }
    interface IShootable
    {
        public int ShootDamage { get; }
        public void Shoot()
        {
            Console.WriteLine($"Unit shoot with damage {ShootDamage}");
        }
    }
    public interface IResourseSourse
    {
        public int Amount { get; set; }

    }

    public interface IStorage
    {
        public int Gold { get; set; }
        public int Wood { get; set; }
        public int Food { get; set; }
        public int MaxAmount { get; }
    }

    
    interface IGather : IResourseSourse
    {
        public void Gather(IResourseSourse source);
        void Gather(object field);
        public void Store(IStorage storage);
        
    }
    interface IAttack
    {   
        public int Damage { get; }
        public void Attack()
        {
            Console.WriteLine($"Unit attack with damage {Damage}");

        }
    }

    interface IInteractivchik
    {
        public void Interact()
        {
            Console.WriteLine($"You have nothing to do here");
        }
    }
    
}
