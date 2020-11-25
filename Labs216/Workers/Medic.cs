using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Workers
{
    class Medic: CharacteristicsWorkers, IMovable, IExamine, ITreats, IHelp
    {
        public Medic(int health, int uron, int skilled, int responsibility)
        {
            _health = health;
            _uron = uron;
            _skilled = skilled;
            _responsibility = responsibility;
        }
        public void Move()
        {
            Console.WriteLine("Medic moving");
        }
        public void Examine()
        {
            Console.WriteLine("Medic examining");
        }
        public void Treats()
        {
            Console.WriteLine("Medic prescribes a course of treatment");
        }
        public void Help()
        {
            Console.WriteLine("Medic helping");
        }
    }
}
