namespace Labs216.Anisimov.Strategy.Fighters
{
    sealed class WarBoat : Characteristic, IMovable, IShootable
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public int Distance { get; private set; }
        public int ShootDamage { get; private set; }

        public WarBoat(int health, int defense, double speed, int distance, int shootdamage)
        {
            Health = health;
            Defense = defense;
            Speed = speed;
            Distance = distance;
            ShootDamage = shootdamage;
        }
    }
}
