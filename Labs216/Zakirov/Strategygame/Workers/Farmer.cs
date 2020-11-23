using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Strategygame
{
    public class Farmer : Characteristics, IMovable, IGather
    {
        public int Speed { get; private set; }
        public Farmer (int health, int speed)
        {
            Health = health;
            Speed = speed;

        }
        public void Gather()
        {
            Console.WriteLine("Farmer gather psheno");
        }

        public void Move()
        {
            Console.WriteLine("Farmer moving");
        }
    }
 }
