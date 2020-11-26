using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame
{
    class Dvornick : Characteristic, IDlyaChelovekaMirn
    {
        public Dvornick( int maxspeed, int zdorove, int zarobotok)
        {
            _maxspeed = maxspeed;
            _zdorove = zdorove;
            _money = zarobotok;
        }
        public void Work()
        {
            Console.WriteLine("Утром я выхожу на улицу и привожу её в порядок");
            _zdorove -= 2;
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

        void IDlyaChelovekaMirn.Income()
        {
            Console.WriteLine($"Зарабатываю {_money}");
        }
    }
}
