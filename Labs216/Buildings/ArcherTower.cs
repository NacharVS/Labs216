using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Buildings
{
    class ArcherTower: CharacteristicsBuildings, IForBluindings
    {
        public ArcherTower(int health, int defence)
        {
            _health = health;
            _defence = defence;
        }
        public void Collab()
        {
            Console.WriteLine("You collab with ArcherTower");
        }

    }
}
