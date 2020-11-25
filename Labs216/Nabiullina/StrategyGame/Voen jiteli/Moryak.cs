using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame.Voen_jiteli
{
    class Moryak : Characteristic, IWork, ISleep, ICharge
    {
        public Moryak(int zdorove, int yron, int minspeed, int maxspeed, int money)
        {
            _dmg = yron;
            _maxspeed = maxspeed;
            _minspeed = minspeed;
            _zdorove = zdorove;
            _money = money;
        }
        public void Charge()
        {
            Console.WriteLine("OOOY, NO! Пираааты... пиу-пиу-пиу");
        }

        public void Sleep()
        {
            Console.WriteLine("Пора набраться сил. Я спать!");
        }

        public void Work()
        {
            Console.WriteLine(" Я путешествую на лодке и ловлю рыбу.\n" +
                 "Мне стоит охранять нашу землю, от пиратов!");
        }
    }
}
