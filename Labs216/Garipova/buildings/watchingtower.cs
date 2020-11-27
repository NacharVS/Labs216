using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.buildings
{
    class watchingtower : Characteristicsbuildings, IBuildings
    {
        public watchingtower(int defence)
        {
            _defence = defence;
        }
        public void Collabaration()
        {
            Console.WriteLine("watchingtower collabaration");
        }
    }
}
