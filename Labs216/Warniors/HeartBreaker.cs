﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Warniors
{
    class HeartBreaker: Characteristics, IHeartBreakers, IMSh
    {
        public HeartBreaker(int health, int uron, int success, int intuition, int attention, int beauty)
        {
            _health = health;
            _uron = uron;
            _success = success;
            _intuition = intuition;
            _attention = attention;
            _beauty = beauty;
        }
        public void Move()
        {
            Console.WriteLine("HeartBreaker moving");
        }
        public void Shoot()
        {
            Console.WriteLine("HeartBreaker shooting with his eyes");
        }
        public void Blind()
        {
            Console.WriteLine("HeartBreak blinding with its beauty");
        }
    }
}
