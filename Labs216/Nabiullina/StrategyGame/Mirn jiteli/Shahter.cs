using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame
{
    class Shahter : Characteristic, IDlyaChelovekaMirn
    {
        public Shahter(int maxspeed, int zdorove, int telegka, int yglyakg, int money)
        {
            _maxspeed = maxspeed;
            _zdorove = zdorove;
            _money = money;
            _hranenie = telegka;
            _zarobotok = yglyakg;
        }

        public void Movement()
        {
            Console.WriteLine("Я спускаюсь в шахту");
            if (_zdorove >= 2)
            {
                _zdorove -= 2;
            }
            else
            {
                Console.WriteLine("Я не могу спуститься! Стоит отдохнуть, я засыпаю...");
            }

        }

        public void Work()
        {
            Console.WriteLine("Я добываю уголь");
           
            if (_hranenie*20<_zarobotok & _zdorove>=1)
            {
                _zarobotok += 1;
                _money += 55;
                _zdorove -= 1;
            }
            else
            {
                if (_hranenie * 20 > _zarobotok)
                {
                    Console.WriteLine("Тележки переполненны!");
                }
                if (_zdorove < 1)
                {
                    Console.WriteLine("У меня нет сил, я устал!");
                }
            }
        }

        public void Sleep()
        {
            Console.WriteLine("Оу, я утомился. Пошёл спать.");
            _zdorove += 2;
        }

        public void Income()
        {
            Console.WriteLine($" Не хухры-мухры, смотри сколько у меня денег {_money}. \n Не беспокойся, у тебя тоже когда-нибудь будет столько:)");
        }
    }
}
