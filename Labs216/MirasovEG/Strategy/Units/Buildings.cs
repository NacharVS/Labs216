using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labs216.MirasovEG.Strategy.Units
{
    class Farm : CharacteristicBuilding, IBuilding
    {
        public Farm(int health, int defence)
        {
            _health = health;
            _defense = defence;
        }
        public void Profit()
        {
            while (!IsDestroyed)
            {
                Thread.Sleep(2000);
                Console.WriteLine("+10 wheat");
            }
        }
    }

    class Sawmill : CharacteristicBuilding, IBuilding
    {
        public Sawmill(int health, int defence)
        {
            _health = health;
            _defense = defence;
        }
        public void Profit()
        {
            while (!IsDestroyed)
            {
                Thread.Sleep(2000);
                Console.WriteLine("+10 wood");
            }
        }
    }

    class Mine : CharacteristicBuilding, IBuilding
    {
        public Mine(int health, int defence)
        {
            _health = health;
            _defense = defence;
        }
        public void Profit()
        {
            while (!IsDestroyed)
            {
                Thread.Sleep(2000);
                Console.WriteLine("+10 ore");
            }
        }
    }

    class Townhall : CharacteristicBuilding, IBuilding
    {
        public Townhall(int health, int defence)
        {
            _health = health;
            _defense = defence;
        }
        public void Profit()
        {
            while (!IsDestroyed)
            {
                Thread.Sleep(2000);
                Console.WriteLine("+100 coin");
            }
        }
    }

    class Tower : CharacteristicBuilding, IWarBuilding
    {
        public int _distance { get; private set; }
        public Tower(int health, int defence, int dmgBuild, int distance)
        {
            _health = health;
            _defense = defence;
            _dmgBuild = dmgBuild;
            _distance = distance;
        }

        public void Shoot()
        {
            Console.WriteLine($"A shot from the tower deals: {_dmgBuild}");
        }
    }


}
