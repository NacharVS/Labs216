using System;

namespace Labs216.Anisimov.Strategy.Units
{
    sealed class Knight : Characteristic, IWarUnit
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public string UnitType { get; } = "ground";

        public Knight(int health, int defense, double speed, int damage)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
            Damage = damage;
        }

        public void Attack()
        {
            Console.WriteLine($"Knught attack untit with damage: {Damage}");
        }

        public void Move()
        {
            Console.WriteLine($"Knight move in the {UnitType} with speed: {Speed}");
        }
    }

    sealed class Archer : Characteristic, IWarUnit, IShootable
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public string UnitType { get; } = "ground";
        public int Distance { get; private set; }
        public int ShootDamage { get; private set; }

        public Archer(int health, int defense, double speed, int damage, int distance, int shootdamage)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
            Damage = damage;
            Distance = distance;
            ShootDamage = shootdamage;
        }

        public void Attack()
        {
            Console.WriteLine($"Archer attack untit with damage: {Damage}");
        }

        public void Move()
        {
            Console.WriteLine($"Archer move in the {UnitType} with speed: {Speed}");
        }

        public void Shoot()
        {
            Console.WriteLine($"Archer shoot untit on distance -- {Distance} -- with damage: {ShootDamage}");
        }
    }

    sealed class WarBoat : Characteristic, IWarUnit
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public string UnitType { get; } = "water";

        public WarBoat(int health, int defense, double speed, int damage)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
            Damage = damage;
        }

        public void Attack()
        {
            Console.WriteLine($"WarBoat attack untit with damage: {Damage}");
        }

        public void Move()
        {
            Console.WriteLine($"WarBoat move in the {UnitType} with speed: {Speed}");
        }
    }

    sealed class WarHelicopter : Characteristic, IWarUnit, IShootable
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public string UnitType { get; } = "air";
        public int Distance { get; private set; }
        public int ShootDamage { get; private set; }

        public WarHelicopter(int health, int defense, double speed, int damage, int shootdamage)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
            Damage = damage;
            ShootDamage = shootdamage;
        }

        public void Attack()
        {
            Console.WriteLine($"WarHelicopter attack untit with damage: {Damage}");
        }

        public void Move()
        {
            Console.WriteLine($"WarHelicopter move in the {UnitType} with speed: {Speed}");
        }

        public void Shoot()
        {
            Console.WriteLine($"WarHelicopter shoot untit with damage: {ShootDamage}");
        }
    }

    sealed class Spearman : Characteristic, IWarUnit
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public string UnitType { get; } = "ground";

        public Spearman(int health, int defense, double speed, int damage)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
            Damage = damage;
        }

        public void Attack()
        {
            Console.WriteLine($"Spearman attack untit with damage: {Damage}");
        }

        public void Move()
        {
            Console.WriteLine($"Spearman move in the {UnitType} with speed: {Speed}");
        }
    }
}
