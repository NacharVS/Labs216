using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Workers
{
    class Cook: CharacteristicsWorkers, ICook
    {
        public Cook(int health, int uron, int skilled, int responsibility)
        {
            _health = health;
            _uron = uron;
            _skilled = skilled;
            _responsibility = responsibility;
        }
        public void Move()
        {
            Console.WriteLine("Cook moving");
        }
        public void Cooking()
        {
            Console.WriteLine("Cook cooking");
        }
    }
}
