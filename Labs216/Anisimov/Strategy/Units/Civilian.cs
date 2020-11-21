namespace Labs216.Anisimov.Strategy.Units
{
    sealed class Farmer : Characteristic, IWorkable, IMovable
    {
        public double Speed { get; private set; }
        public string UnitType { get; } = "ground";
        public string Profesion { get; } = "farmer";

        public Farmer(int health, int defense, double speed)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
        }
    }

    sealed class CivBoat : Characteristic, IWorkable, IMovable
    {
        public double Speed { get; private set; }
        public string UnitType { get; } = "water";
        public string Profesion { get; } = "transport";

        public CivBoat(int health, int defense, double speed)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
        }
    }

    sealed class CivHelicopter : Characteristic, IWorkable, IMovable
    {
        public double Speed { get; private set; }
        public string UnitType { get; } = "air";
        public string Profesion { get; } = "transport";

        public CivHelicopter(int health, int defense, double speed)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
        }
    }

    sealed class Doctor : Characteristic, IWorkable, IMovable
    {
        public double Speed { get; private set; }
        public string UnitType { get; } = "ground";
        public string Profesion { get; } = "healer";

        public Doctor(int health, int defense, double speed)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
        }
    }

    sealed class Miner : Characteristic, IWorkable, IMovable, IGather
    {
        public double Speed { get; private set; }
        public string UnitType { get; } = "ground";
        public string Profesion { get; } = "miner";
        public int Count { get; set; }
        public string GatherType { get; } = "gold";

        public Miner(int health, int defense, double speed)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
        }
    }
}
