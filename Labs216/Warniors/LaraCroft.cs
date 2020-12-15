using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Warniors
{
    class LaraCroft: Characteristics, ILaraCroft, IMSh
    {
        public LaraCroft(int health, int force, int uron, int adroitnes, int malice, int intuition, int attention, int beauty)
        {
            _health = health;
            _force = force;
            _uron = uron;
            _adroitnes = adroitnes;
            _malice = malice;
            _intuition = intuition;
            _attention = attention;
            _beauty = beauty;
        }
        public void Move()
        {
            Console.WriteLine("LaraCroft moving ");
        }
        public void Shoot()
        {
            Console.WriteLine("LaraCroft shooting");
        }
        
        public void Fight()
        {
            Console.WriteLine("LaraCroft fighting");
        }
    }
}
