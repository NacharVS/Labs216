using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame.Voen_jiteli
{
    class Moryak : Characteristic, IWork, ISleep, IShoot
    {
        public Moryak(int zdorove, int yron,  int maxspeed, int puli)
        {
            _dmg = yron;
            _maxspeed = maxspeed;
            _zdorove = zdorove;
            _puli = puli;
        }
        public void Shoot()
        {
            Console.WriteLine("OOOY, NO! Пираааты... пиу-пиу-пиу");
            _puli -= 2;
            Console.WriteLine($"Осталось {_puli} пуль");
        }

        public void Sleep()
        {
            Console.WriteLine("Пора набраться сил. Я спать!");
            
             _zdorove += 2; 
           
        }

        public void Work()
        {
            Console.WriteLine(" Я путешествую на лодке и ловлю рыбу.\n" +
                 "Мне стоит охранять нашу землю, от пиратов!");
        }
    }
}
