using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame
{
    class Lesoryb : Characteristic, IMovement, IWork, ISleep
    {
        public Lesoryb( int maxspeed, int zdorove)
        {
            _maxspeed = maxspeed;
            _zdorove = zdorove;
        }
        public void Movement()
        {
            Console.WriteLine("Я бегууу!");

        }

        public void Work()
        {
            Console.WriteLine("Рублю деревья");
        }

        public void Sleep()
        {
            Console.WriteLine("Лесоруб устал и пошел спать");
        }
    }
}
