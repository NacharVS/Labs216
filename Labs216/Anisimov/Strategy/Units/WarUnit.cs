namespace Labs216.Anisimov.Strategy.Units
{
    sealed class Knight : Characteristic, IAttack, IMovable
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public string UnitType { get; } = "ground";
        public string AttackType { get; } = "heavy";

        public Knight(int health, int defense, double speed, int damage)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
            Damage = damage;
        }
    }

    sealed class Archer : Characteristic, IAttack, IMovable, IShootable
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public string UnitType { get; } = "ground";
        public string AttackType { get; } = "light";
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
    }

    sealed class WarBoat : Characteristic, IAttack, IMovable, IShootable
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public string UnitType { get; } = "water";
        public string AttackType { get; } = "heavy";
        public int Distance { get; private set; }
        public int ShootDamage { get; private set; }

        public WarBoat(int health, int defense, double speed, int damage, int distance, int shootdamage)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
            Damage = damage;
            Distance = distance;
            ShootDamage = shootdamage;
        }
    }

    sealed class WarHelicopter : Characteristic, IAttack, IMovable, IShootable
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public string UnitType { get; } = "air";
        public string AttackType { get; } = "medium";
        public int Distance { get; private set; }
        public int ShootDamage { get; private set; }

        public WarHelicopter(int health, int defense, double speed, int damage, int distance, int shootdamage)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
            Damage = damage;
            Distance = distance;
            ShootDamage = shootdamage;
        }
    }

    sealed class Spearman : Characteristic, IAttack, IMovable
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public string UnitType { get; } = "ground";
        public string AttackType { get; } = "medium";

        public Spearman(int health, int defense, double speed, int damage)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
            Damage = damage;
        }
    }
}
