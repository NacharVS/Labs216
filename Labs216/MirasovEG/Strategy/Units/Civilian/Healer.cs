using System;

namespace Labs216.MirasovEG.Strategy.Units.Civilian
{
    class Healer : CharacteristicPerson, IMovable, IAttack, IHeal
    {
        public Healer(int health, int defence, int dmg, int speed)
        {
            _health = health;
            _defense = defence;
            _DMG = dmg;
            _speed = speed;
        }

        public void Heal()
        {
            Console.WriteLine($"The Healer cured the whole party");
        }

        public void MeleeAttack()
        {
            Console.WriteLine($"Healer attack: {_DMG}");
        }
        public void Move()
        {
            Console.WriteLine($"Healer move with speed: {_speed}");
        }

    }
}
