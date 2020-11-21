using System;

namespace Labs216.MirasovEG.Strategy.Units.Warior
{
    class Archer : CharacteristicPerson, IMovable, IShoot
    {
        public int Distance { get; private set; }
        public Archer(int health, int defence, int dmg, int speed, int distance)
        {
            _health = health;
            _defense = defence;
            _DMG = dmg;
            _speed = speed;
            Distance = distance;
        }

        public void Shoot()
        {
            Console.WriteLine($"Shot from a bow deals: {_DMG}");
        }

        public void Move()
        {
            Console.WriteLine($"Archer move with speed: {_speed}");
        }

    }
}
