using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Buildings
{
    class Colledge: CharacteristicsBuildings, IForBluindings
    {
        public Colledge(int health, int deference)
        {
            _health = health;
            _defence = deference;
        }
        public void Collab()
        {
            Console.WriteLine("You collab with Colledge");
        }
    }
}
