using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame
{
    class Povar : Characteristic, IDlyaChelovekaMirn
    {
        public Povar ( int maxspeedgotovit, int zdorove, int zarobotoc, int polki, int pirogki)
        {

            _maxspeed = maxspeedgotovit;
            _zdorove = zdorove;
            _money = zarobotoc;
            _hranenie = polki;
            _zarobotok = pirogki;
        }
        public void Movement()
        {
            Console.WriteLine("Я бегу готовить кушать");
            if (_zdorove >= 1)
            {
                _zdorove -= 1;
            }
            else
            {
                Console.WriteLine("У меня недостаточно сил! Стоит отдохнуть.");
            }

        }

        public void Work()
        {
            Console.WriteLine("Могу приготовить покушать. У меня самые вкусные бутерброды и великолепный торт!");
            if (_hranenie*20<_zarobotok)
            {
                _zarobotok += 1;
                _money += 50;
            }
            else
            {
                Console.WriteLine("У меня недостаточно места на полках!");
            }
            if (_zdorove >= 2)
            {
                _zdorove -= 2;
            }
            else
            {
                Console.WriteLine("Утомился Я, пойду спать - набираться сил ");
            }
        }

        public void Sleep()
        {
            Console.WriteLine("Покушали и спать ");
            _zdorove += 2;
        }

        public void Income()
        {
            Console.WriteLine($"На моем счету сейчас: {_money}");
        }
    }
}
