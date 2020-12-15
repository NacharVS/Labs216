using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Warniors
{
    class Luckyguy: Characteristics, ILuckyguy, IMSh
    {
        public Luckyguy(int health, int uron, int force, int adroitnes, int success, int malice, int intuition, int attention, int beauty)
        {
            _health = health;
            _uron = uron;
            _force = force;
            _adroitnes = adroitnes;
            _success = success;
            _malice = malice;
            _intuition = intuition;
            _attention = attention;
            _beauty = beauty;
        }
        public void Move()
        {
            Console.WriteLine("Luckyguy moving");
        }
        public void Shoot()
        {
            Console.WriteLine("Luckyguy shooting");
        }
        
        public void Blind()
        {
            Console.WriteLine("Luckyguy blinding");
        }
        public void Fight()
        {
            Console.WriteLine("Luckyguy fighting");
        }
        public void Jump()
        {
            Console.WriteLine("Luckyguy jumping");
        }
    }
}
