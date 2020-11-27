using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.buildings
{
    class Castle : Characteristicsbuildings, IBuildings
    {
        public Castle(int defence)
        {
            _defence = defence;
        }
        public void Collabaration()
        {
            Console.WriteLine("castle collabaration");
        }
    }
}
