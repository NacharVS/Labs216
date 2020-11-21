using System;

namespace Labs216.MirasovEG.Strategy.Units
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
            wareHouse.ResourcesWheat = 5;
            Console.WriteLine("The farmer works on arable land: + 5 wheat");
        }
    }

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
            wareHouse.ResourcesOre = 5;
            Console.WriteLine("A miner works in a mine: +5 Ore");
        }
    }

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
            wareHouse.ResourcesWood = 5;
            Console.WriteLine("Woodman working in the forest: + 5 Wood");
        }
    }

    class Builder : CharacteristicPerson, IMovable, IAttack
    {
        public Builder(int health, int defence, int dmg, int speed)
        {
            _health = health;
            _defense = defence;
            _DMG = dmg;
            _speed = speed;
        }
        public void MeleeAttack()
        {
            Console.WriteLine($"Builder attack: {_DMG}");
        }
        public void Move()
        {
            Console.WriteLine($"Builder move with speed: {_speed}");
        }
      
    }

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
