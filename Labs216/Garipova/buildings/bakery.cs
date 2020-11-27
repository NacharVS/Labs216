using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.buildings
{
    class bakery : Characteristicsbuildings, IBuildings
    {
        public bakery(int defence)
        {
         _defence = defence;
        }
       public void Collabaration()
       {
                Console.WriteLine("bakery collabaration");
       }
    }
}
