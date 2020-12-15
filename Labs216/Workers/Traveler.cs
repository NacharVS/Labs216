using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Workers
{
    class Traveler: CharacteristicsWorkers, ITraveler, IWorkers
    {
        public Traveler(int health, int uron, int skilled, int responsibility)
        {
            _health = health;
            _uron = uron;
            _skilled = skilled;
            _responsibility = responsibility;
        }
        public void Move()
        {
            Console.WriteLine("Traveler moving");
        }
        public void EnjoyLife()
        {
            Console.WriteLine("Traveler enjoying life!");
        }
    }
}
