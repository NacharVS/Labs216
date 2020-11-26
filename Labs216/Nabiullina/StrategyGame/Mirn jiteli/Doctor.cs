using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame
{
    class Doctor : Characteristic, IDlyaChelovekaMirn
    {
        public Doctor(  int operatciyavremya, int zdorove, int zarobotok)
        {
            _maxspeed = operatciyavremya;
            _zdorove = zdorove;
            _money = zarobotok;
        }
        public void Movement()
        {
            Console.WriteLine("Я  могу прыгать на скакалке!");
            _zdorove -= 2;

        }
        public void Work()
        {
            Console.WriteLine($"Я лечу людей! \n Одна операция длится {_maxspeed}");
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
