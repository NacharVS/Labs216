using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Warniors
{
    class Mario: Characteristics, IMario
    {
        public Mario(int health, int uron, int force, int adroitnes, int attention, int success)
        {
            _health = health;
            _uron = uron;
            _force = force;
            _adroitnes = adroitnes;
            _attention = attention;
            _success = success;
        }
        public void Move()
        {
            Console.WriteLine("Mario moving");
        }
        public void Shoot()
        {
            Console.WriteLine("Mario shooting");
        }
        public void Jump()
        {
            Console.WriteLine("Mario jumping");
        }
    }
}
