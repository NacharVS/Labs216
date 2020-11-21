using System;

namespace Labs216.MirasovEG.Strategy.Units.Warior
{
    class Сatapult : CharacteristicPerson, IMovable, IShoot
    {
        public int Distance { get; private set; }
        public Сatapult(int health, int defence, int dmg, int speed, int distance)
        {
            _health = health;
            _defense = defence;
            _DMG = dmg;
            _speed = speed;
            Distance = distance;
        }

        public void Shoot()
        {
            Console.WriteLine($"The catapult core deals damage: {_DMG}");
        }

        public void Move()
        {
            Console.WriteLine($"Сatapult move with speed: {_speed}");
        }
    }
}
