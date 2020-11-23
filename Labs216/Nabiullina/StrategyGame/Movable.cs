using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame
{
    class Movable
    {
        interface IMovable
        {
            public const int minSpeed = 0;
            private static int maxSpeed = 60;
            public void Move()
            {
                Console.WriteLine("Walking");
            }
            protected internal string Name { get; set; }
            public delegate void MoveHandler(string massage);
            public event MoveHandler MoveEvent;
        }
    }
}
