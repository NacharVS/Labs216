using System;
using Labs216.MirasovEG.Strategy.Units.Buildings;

namespace Labs216.MirasovEG.Strategy.Units.Civilian
{
    class Farmer : CharacteristicPerson, IMovable, IWork, IAttack
    {
        public Farmer(int health, int defence, int dmg, int speed)
        {
            _health = health;
            _defense = defence;
            _DMG = dmg;
            _speed = speed;
        }

        public void MeleeAttack()
        {
            Console.WriteLine($"Farmer attack: {_DMG}");
        }

        public void Move()
        {
            Console.WriteLine($"Farmer move with speed: {_speed}");
        }
        public void Work(WareHouse wareHouse)
        {
            wareHouse.AddWheat(5);
            Console.WriteLine("The farmer works on arable land: + 5 wheat");
        }
    }
}
