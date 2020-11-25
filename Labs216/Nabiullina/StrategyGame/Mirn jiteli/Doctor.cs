using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame
{
    class Doctor : Characteristic, IMovement, IWork, ISleep, IIncome

    {
        public Doctor(  int maxspeed, int zdorove, int money)
        {
            _maxspeed = maxspeed;
            _zdorove = zdorove;
            _money = money;
        }
        public void Movement()
        {
            Console.WriteLine("Я прыгать на скакалке!");
            _zdorove -= 2;

        }
        public void Work()
        {
            Console.WriteLine("Я лечу людей!");
        }

        public void Sleep()
        {
            Console.WriteLine("Персонаж пошел спать");
            _zdorove += 3;
        }

        public void Income()
        {
            Console.WriteLine($"В месяц я зарабатываю {_money} рублей");
        }
    }
}
