using System;

namespace Labs216.Anisimov.Strategy.Units
{
    sealed class Wall : Characteristic, IBuilding
    {
        public Wall(int health, int defense)
        {
            Health = health;
            Defense = defense;
        }

        public void Interact()
        {
            Console.WriteLine($"It is a wall. It is looks like {Health} hp");
        }
    }

    sealed class Gate : Characteristic, IBuilding
    {
        public Gate(int health, int defense)
        {
            Health = health;
            Defense = defense;
        }

        public void Interact()
        {
            Console.WriteLine($"You move through the gate");
        }
    }

    sealed class Tower : Characteristic, IBuilding, IShootable
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
            Console.WriteLine($"You move in the tower");
        }

        public void Shoot()
        {
            Console.WriteLine($"Tower shoot untit on distance -- {Distance} -- with damage: {ShootDamage}");
        }
    }

    sealed class House : Characteristic, IBuilding
    {
        public House(int health, int defense, int distance, int shootdamage)
        {
            Health = health;
            Defense = defense;
        }

        public void Interact()
        {
            Console.WriteLine($"You move in the house");
        }
    }

    sealed class Hospital : Characteristic, IBuilding
    {
        public Hospital(int health, int defense, int distance, int shootdamage)
        {
            Health = health;
            Defense = defense;
        }

        public void Interact()
        {
            Console.WriteLine($"You move in the hospital");
        }
    }
}
