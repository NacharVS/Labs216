using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.buildings
{
    class ArcherTower : Characteristicsbuildings, IBuildings
    {
        public ArcherTower(int defence)
        {
            _defence = defence;
        }
        public void Collabaration()
        {
            Console.WriteLine("ArcherTower collabaration");
        }
    }
}
