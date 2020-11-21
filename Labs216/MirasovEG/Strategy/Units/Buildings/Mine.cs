using System;
using System.Threading;

namespace Labs216.MirasovEG.Strategy.Units.Buildings
{
    class Mine : CharacteristicBuilding, IProfit
    {
        public Mine(int health, int defence)
        {
            _health = health;
            _defense = defence;
        }
        public void Profit(WareHouse wareHouse)
        {
            wareHouse.AddOre(10);
            Thread.Sleep(2000);
            Console.WriteLine("+10 ore");

        }

    }
}
