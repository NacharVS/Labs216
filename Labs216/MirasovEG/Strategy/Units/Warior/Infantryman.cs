using System;

namespace Labs216.MirasovEG.Strategy.Units.Warior
{
    class Infantryman : CharacteristicPerson, IAttack, IMovable
    {
        public Infantryman(int health, int defence, int dmg, int speed)
        {
            _health = health;
            _defense = defence;
            _DMG = dmg;
            _speed = speed;
        }

        public void MeleeAttack()
        {
            Console.WriteLine($"Sword strikes: {_DMG}");
        }

        public void Move()
        {
            Console.WriteLine($"Infantryman move with speed: {_speed}");
        }

    }
}
