using System;
namespace Labs216.MirasovEG.Strategy.Units.Warior
{
    class Cavalry : CharacteristicPerson, IAttack, IMovable
    {
        public Cavalry(int health, int defence, int dmg, int speed)
        {
            _health = health;
            _defense = defence;
            _DMG = dmg;
            _speed = speed;
        }

        public void MeleeAttack()
        {
            Console.WriteLine($"Lance strikes: {_DMG}");
        }

        public void Move()
        {
            Console.WriteLine($"Cavalry move with speed: {_speed}");
        }
    }
}
