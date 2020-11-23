using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame
{
    interface IMovable
    {
        public const int minSpeed = 0;
        private static int maxSpeed = 60;
        static double GetTime(double distance, double speed) => distance / speed;
        static int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value > 0) maxSpeed = value;

            }
        }
        public void Move()
        {
            Console.WriteLine("Walking");
        }
        protected internal string Name { get; set; }
        public delegate void MoveHandler(string massage);
        public event MoveHandler MoveEvent;
    }
}
