using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame.Voen_jiteli
{
    class Moryak : Characteristic, IDlyaVoennogo
    {
        public Moryak(int zdorove, int yron,  int maxspeed, int puli, int sleep)
        {
            _dmg = yron;
            _maxspeed = maxspeed;
            _zdorove = zdorove;
            _puli = puli;
        }

        public void Movement()
        {
            Console.WriteLine("Мне стоит взять лодку.");
            if(_zdorove>=1)
            {
                _zdorove -= 1;
            }
            else
            {
                Console.WriteLine("Кажется у меня нет сил:(");
            }
        }

        public void Shoot()
        {
            Console.WriteLine("OOOY, NO! Пираааты... пиу-пиу-пиу");
            if (_puli >= 2 & _zdorove>=2)
            {
                _puli -= 2;
                _zdorove -= 2;
            }
            else
            {
                if (_zdorove<2)
                {
                    Console.WriteLine("Сил моих больше нет! Я СПАТЬ.");
                }
                if (_puli < 2)
                {
                    Console.WriteLine($"О, неет! У меня закончились пули...");
                }
            }
        }
        public void Sleep()
        {
            Console.WriteLine("Пора набраться сил. Я спать!");
            
             _zdorove += 2; 
           
        }

        public void Work()
        {
            Console.WriteLine(" Я путешествую на лодке и ловлю рыбу.");
            

        }
    }
}
