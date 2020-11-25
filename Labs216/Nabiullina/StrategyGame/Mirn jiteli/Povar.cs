using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame
{
    class Povar : Characteristic, IMovement, IWork, ISleep
    {
        public Povar ( int maxspeed, int zdorove)
        {

            _maxspeed = maxspeed;
            _zdorove = zdorove;

        }
        public void Movement()
        {
            Console.WriteLine("Я бегу готовить кушать");

        }

        public void Work()
        {
            Console.WriteLine("Могу приготовить покушать");
        }

        public void Sleep()
        {
            Console.WriteLine("Покушали и спать ");
        }
    }
}
