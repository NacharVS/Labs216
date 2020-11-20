using System;

namespace Labs216.Anisimov.Strategy.Units
{
    sealed class Farmer : Characteristic, ICivilian
    {
        public double Speed { get; private set; }
        public string UnitType { get; } = "ground";

        public Farmer(int health, int defense, double speed)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"Farmer move in the {UnitType} with speed: {Speed}");
        }

        public void Work()
        {
            Console.WriteLine($"Farmer work in field");
        }
    }

    sealed class CivBoat : Characteristic, ICivilian
    {
        public double Speed { get; private set; }
        public string UnitType { get; } = "water";

        public CivBoat(int health, int defense, double speed)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"CivBoat move in the {UnitType} with speed: {Speed}");
        }

        public void Work()
        {
            Console.WriteLine($"CivBoat is cargo transportation");
        }
    }

    sealed class CivHelicopter : Characteristic, ICivilian
    {
        public double Speed { get; private set; }
        public string UnitType { get; } = "air";

        public CivHelicopter(int health, int defense, double speed)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"Helicopter move in {UnitType} with speed: {Speed}");
        }

        public void Work()
        {
            Console.WriteLine($"Helicopter is civilian trensportation");
        }
    }

    sealed class Doctor : Characteristic, ICivilian
    {
        public double Speed { get; private set; }
        public string UnitType { get; } = "ground";

        public Doctor(int health, int defense, double speed)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"Doctor move in {UnitType} with speed: {Speed}");
        }

        public void Work()
        {
            Console.WriteLine($"Doctor treats people");
        }
    }

    sealed class Politican : Characteristic, ICivilian
    {
        public double Speed { get; private set; }
        public string UnitType { get; } = "ground";

        public Politican(int health, int defense, double speed)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"Politican move in {UnitType} with speed: {Speed}");
        }

        public void Work()
        {
            Console.WriteLine($"Politican deceives people");
        }
    }
}
