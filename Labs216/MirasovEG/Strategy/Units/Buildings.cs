using System;
using System.Threading;

namespace Labs216.MirasovEG.Strategy.Units
{
    class Farm : CharacteristicBuilding, IProfit
    {
        
        public Farm(int health, int defence)
        {
            _health = health;
            _defense = defence;
        }
        public void Profit(WareHouse wareHouse)
        {
            wareHouse.ResourcesWheat = 10;
            Thread.Sleep(2000);
            Console.WriteLine("+10 wheat");
            
        }
    }

    class Sawmill : CharacteristicBuilding, IProfit
    {
        public Sawmill(int health, int defence)
        {
            _health = health;
            _defense = defence;
        }
        public void Profit(WareHouse wareHouse)
        {
            wareHouse.ResourcesWood = 10;
            Thread.Sleep(2000);
            Console.WriteLine("+10 wood");
        }
    }

    class Mine : CharacteristicBuilding, IProfit
    {
        public Mine(int health, int defence)
        {
            _health = health;
            _defense = defence;
        }
        public void Profit(WareHouse wareHouse)
        {
            wareHouse.ResourcesOre = 10;
            Thread.Sleep(2000);
            Console.WriteLine("+10 ore");
            
        }
    }

    class Townhall : CharacteristicBuilding, IProfit
    {
        public Townhall(int health, int defence)
        {
            _health = health;
            _defense = defence;
        }
        public void Profit(WareHouse wareHouse)
        {
            wareHouse.ResourcesCoin = 100;
            Thread.Sleep(2000);
            Console.WriteLine($"+100 coin");
        }
    }

    class Tower : CharacteristicBuilding, IShoot
    {
        public int Distance { get; private set; }
        public Tower(int health, int defence, int dmgBuild, int distance)
        {
            _health = health;
            _defense = defence;
            _dmgBuild = dmgBuild;
            Distance = distance;
        }

        public void Shoot()
        {
            Console.WriteLine($"A shot from the tower deals: {_dmgBuild}");
        }
    }

    public class WareHouse : CharacteristicBuilding
    {

        public WareHouse(int health, int defence)
        {
            _health = health;
            _defense = defence;
        }


        private int _resourcesWheat;
        public int ResourcesWheat
        {
            get => _resourcesWheat;
            set => _resourcesWheat += value;
        }

        private int _resourcesWood;
        public int ResourcesWood
        {
            get => _resourcesWood;
            set => _resourcesWood += value;
        }

        private int _resourcesOre;
        public int ResourcesOre
        {
            get => _resourcesOre;
            set => _resourcesOre += value;
        }

        private int _resourcesCoin;
        public int ResourcesCoin
        {
            get => _resourcesCoin;
            set => _resourcesCoin += value;
        }

    }
}
