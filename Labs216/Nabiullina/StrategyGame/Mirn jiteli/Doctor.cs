using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame
{
    class Doctor : Characteristic, IMovement, IWork, ISleep
    {
        public Doctor(  int maxspeed, int zdorove)
        {
            _maxspeed = maxspeed;
            _zdorove = zdorove;
        }
        public void Movement()
        {
            Console.WriteLine("Я умею двигаться!");

        }
        public void Work()
        {
            Console.WriteLine("Я лечу людей!");
        }

        public void Sleep()
        {
            Console.WriteLine("Персонаж пошел спать");
        }
    }
}
