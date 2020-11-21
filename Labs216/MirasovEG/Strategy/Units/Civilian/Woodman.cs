using System;
using Labs216.MirasovEG.Strategy.Units.Buildings;

namespace Labs216.MirasovEG.Strategy.Units.Civilian
{
    class Woodman : CharacteristicPerson, IMovable, IWork, IAttack
    {
        public Woodman(int health, int defence, int dmg, int speed)
        {
            _health = health;
            _defense = defence;
            _DMG = dmg;
            _speed = speed;
        }
        public void MeleeAttack()
        {
            Console.WriteLine($"Woodman attack: {_DMG}");
        }
        public void Move()
        {
            Console.WriteLine($"Woodman move with speed: {_speed}");
        }
        public void Work(WareHouse wareHouse)
        {
            wareHouse.AddWood(5);
            Console.WriteLine("Woodman working in the forest: + 5 Wood");
        }
    }
}
