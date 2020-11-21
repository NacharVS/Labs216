using System;
using System.Threading;

namespace Labs216.MirasovEG.Strategy.Units.Buildings
{
    class Townhall : CharacteristicBuilding, IProfit
    {
        public Townhall(int health, int defence)
        {
            _health = health;
            _defense = defence;
        }
        public void Profit(WareHouse wareHouse)
        {
            wareHouse.AddCoin(100);
            Thread.Sleep(2000);
            Console.WriteLine($"+100 coin");
        }
    }
}
