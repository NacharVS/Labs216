using System;
using Labs216.MirasovEG.Strategy.Units.Buildings;

namespace Labs216.MirasovEG.Strategy.Units.Civilian
{
    class Miner : CharacteristicPerson, IMovable, IWork, IAttack
    {
        public Miner(int health, int defence, int dmg, int speed)
        {
            _health = health;
            _defense = defence;
            _DMG = dmg;
            _speed = speed;
        }

        public void MeleeAttack()
        {
            Console.WriteLine($"Miner attack: {_DMG}");
        }

        public void Move()
        {
            Console.WriteLine($"Miner move with speed: {_speed}");
        }
        public void Work(WareHouse wareHouse)
        {
            wareHouse.AddOre(5);
            Console.WriteLine("A miner works in a mine: +5 Ore");
        }
    }
}
