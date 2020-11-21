using System;

namespace Labs216.MirasovEG.Strategy.Units.Buildings
{
    class Tower : CharacteristicBuilding, IShoot
    {
        public int Distance { get; private set; }
        public Tower(int health, int defence, int dmgBuild, int distance)
        {
            _health = health;
            _defense = defence;
            _dmgBuild = dmgBuild;
            Distance = distance;
        }

        public void Shoot()
        {
            Console.WriteLine($"A shot from the tower deals: {_dmgBuild}");
        }
    }
}
