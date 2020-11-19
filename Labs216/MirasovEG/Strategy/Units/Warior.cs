using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.MirasovEG.Strategy.Units
{
    class Infantryman : CharacteristicPerson, IMeleeWarior
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

    class Archer : CharacteristicPerson, IDistanceWarior
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
    class Cavalry : CharacteristicPerson, IMeleeWarior
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

    class Сatapult : CharacteristicPerson, IDistanceWarior
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

    class Paladin : CharacteristicPerson, IMultiWarior
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
    }
}