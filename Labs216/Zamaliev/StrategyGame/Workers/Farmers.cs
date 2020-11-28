using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zamaliev.StrategyGame.Workers
{
    class Farmers : Characteristic, IMovable, IMinable
    {
        public int Speed { get; set; }


        public void Mine()
        {
            Console.WriteLine("Начал собирать");
        }

        public void Move()
        {
            Console.WriteLine("Начал движение");
        }

    }
}
