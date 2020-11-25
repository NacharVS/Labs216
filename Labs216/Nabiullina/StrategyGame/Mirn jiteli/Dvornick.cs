﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame
{
    class Dvornick : Characteristic, IMovement, IWork, ISleep
    {
        public Dvornick( int maxspeed, int zdorove)
        {
            _maxspeed = maxspeed;
            _zdorove = zdorove;
        }
        public void Work()
        {
            Console.WriteLine("Утром я выхожу на улицу и привожу её в порядок");
        }
        public void Movement()
        {
            Console.WriteLine("Передвигаюсь на уборочной машине");
            _zdorove -= 2;

        }

        public void Sleep()
        {
            Console.WriteLine("Дворник пошел спать");
            _zdorove += 1;
        }
    }
}
