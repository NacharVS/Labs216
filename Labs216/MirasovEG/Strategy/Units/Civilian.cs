using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Labs216.MirasovEG.Strategy
{

    class Farmer : CharacteristicPerson, ICivilian
    {
        public Farmer(int health, int defence, int dmg, int speed)
        {
            _health = health;
            _defense = defence;
            _DMG = dmg;
            _speed = speed;
        }
        public void Move()
        {
            Console.WriteLine($"Farmer move with speed: {_speed}");
        }
        public void Work()
        {
            Console.WriteLine("The farmer works on arable land");
        }
    }

    class Miner : CharacteristicPerson, ICivilian
    {
        public Miner(int health, int defence, int dmg, int speed)
        {
            _health = health;
            _defense = defence;
            _DMG = dmg;
            _speed = speed;
        }
        public void Move()
        {
            Console.WriteLine($"Miner move with speed: {_speed}");
        }
        public void Work()
        {
            Console.WriteLine("A miner works in a mine");
        }
    }

    class Woodman : CharacteristicPerson, ICivilian
    {
        public Woodman(int health, int defence, int dmg, int speed)
        {
            _health = health;
            _defense = defence;
            _DMG = dmg;
            _speed = speed;
        }
        public void Move()
        {
            Console.WriteLine($"Woodman move with speed: {_speed}");
        }
        public void Work()
        {
            Console.WriteLine("Woodman working in the forest");
        }
    }

    class Builder : CharacteristicPerson, ICivilian
    {
        public Builder(int health, int defence, int dmg, int speed)
        {
            _health = health;
            _defense = defence;
            _DMG = dmg;
            _speed = speed;
        }
        public void Move()
        {
            Console.WriteLine($"Builder move with speed: {_speed}");
        }
        public void Work()
        {
            Console.WriteLine("The Builder builds buildings");
        }
    }

    class Healer : CharacteristicPerson, ICivilian
    {
        public Healer(int health, int defence, int dmg, int speed)
        {
            _health = health;
            _defense = defence;
            _DMG = dmg;
            _speed = speed;
        }
        public void Move()
        {
            Console.WriteLine($"Healer move with speed: {_speed}");
        }
        public void Work()
        {
            Console.WriteLine("A healer treats people");
        }
    }
}
