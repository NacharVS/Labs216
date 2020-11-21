using System;
using System.Threading;

namespace Labs216.MirasovEG.Strategy.Units.Buildings
{
    class Sawmill : CharacteristicBuilding, IProfit
    {
        public Sawmill(int health, int defence)
        {
            _health = health;
            _defense = defence;
        }
        public void Profit(WareHouse wareHouse)
        {
            wareHouse.AddWood(10);
            Thread.Sleep(2000);
            Console.WriteLine("+10 wood");
        }
    }
}
