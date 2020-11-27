using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Buildings
{
    class Shop: CharacteristicsBuildings, IForBluindings
    {
        public Shop(int health, int deference)
        {
            _health = health;
            _defence = deference;
        }
        public void Collab()
        {
            Console.WriteLine("You collab with Shop");
        }
    }
}
