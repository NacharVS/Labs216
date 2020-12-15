using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Workers
{
    class Teacher: CharacteristicsWorkers, ITeacher, IWorkers
    {
        public Teacher(int health, int uron, int skilled, int responsibility)
        {
            _health = health;
            _uron = uron;
            _skilled = skilled;
            _responsibility = responsibility;
        }
        public void Move()
        {
            Console.WriteLine("Teacher moving ");
        }
        public void Explain()
        {
            Console.WriteLine("Teacher explaining");
        }
        public void Check()
        {
            Console.WriteLine("Teacher checking");
        }
        public void Help()
        {
            Console.WriteLine("Teacher helping");
        }
    }
}
