using System;

namespace Labs216.MirasovEG.Strategy.Units.Warior
{
    class Paladin : CharacteristicPerson, IMovable, IShoot, IAttack, IHeal
    {
        public int Distance { get; private set; }
        public Paladin(int health, int defence, int dmg, int speed, int distance)
        {
            _health = health;
            _defense = defence;
            _DMG = dmg;
            _speed = speed;
            Distance = distance;
        }

        public void MeleeAttack()
        {
            Console.WriteLine($"Strike of the hammer deals: {_DMG}");
        }
        public void Shoot()
        {
            Console.WriteLine($"A crossbow shot strikes: {_DMG * 0.9}");
        }
        public void Move()
        {
            Console.WriteLine($"Paladin move with speed: {_speed}");
        }

        public void Heal()
        {
            Console.WriteLine("Paladin heal 5 unit");
        }
    }
}
