using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Workers
{
    class Assistant: CharacteristicsWorkers, IAssistant, IWorkers
    {
        public Assistant(int health, int uron, int skilled, int responsibility)
        {
            _health = health;
            _uron = uron;
            _skilled = skilled;
            _responsibility = responsibility;
        }
        public void Move()
        {
            Console.WriteLine("Assistant moving");
        }
        public void Help()
        {
            Console.WriteLine("Assistant helping with everything");
        }
    }
}
