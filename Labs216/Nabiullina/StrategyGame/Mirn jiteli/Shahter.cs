using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame
{
    class Shahter : Characteristic, IMovement, IWork, ISleep
    {
        public Shahter( int maxspeed, int zdorove)
        {
            _maxspeed = maxspeed;
            _zdorove = zdorove;
        }

        public void Movement()
        {
            Console.WriteLine("Я спускаюсь в шахту");

        }

        public void Work()
        {
            Console.WriteLine("Я добываю уголь");
        }

        public void Sleep()
        {
            Console.WriteLine("Оу, я утомился. Пошёл спать.");
        }
    }
}
