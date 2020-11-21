using System;

namespace Labs216.Anisimov.Strategy.Units
{
    sealed class Wall : Characteristic, IInteractive
    {
        public int Distance { get; private set; }
        public int ShootDamage { get; private set; }

        public Wall(int health, int defense)
        {
            Health = health;
            Defense = defense;
        }
    }

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

    sealed class Tower : Characteristic, IInteractive, IShootable
    {
        public int Distance { get; private set; }
        public int ShootDamage { get; private set; }

        public Tower(int health, int defense, int distance, int shootdamage)
        {
            Health = health;
            Defense = defense;
            Distance = distance;
            ShootDamage = shootdamage;
        }

        public void Interact()
        {
            Console.WriteLine($"Move in the tower");
        }
    }

    sealed class Mine : Characteristic, IInteractive, IGather
    {
        public int Count { get; set; }
        public string GatherType { get;} = "gold";

        public Mine(int health, int defense, int count)
        {
            Health = health;
            Defense = defense;
            Count = count;
        }
        public void Interact()
        {
            Console.WriteLine($"You see a mine");
        }
    }

    sealed class GoldStorage : Characteristic, IInteractive , IGather
    {
        public int Count { get; set; }
        public string GatherType { get; } = "gold";

        public GoldStorage(int health, int defense)
        {
            Health = health;
            Defense = defense;
        }

        public void Interact()
        {
            Console.WriteLine($"You see a gold storage");
        }
    }
}
