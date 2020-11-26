using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame
{
    class Lesoryb : Characteristic, IDlyaChelovekaMirn
    {
        public Lesoryb( int maxspeedrubit, int zdorove, int telegka, int derevya)
        {
            _maxspeed = maxspeedrubit;
            _zdorove = zdorove;
            _hranenie = telegka;
            _zarobotok = derevya;
        }
        public void Movement()
        {
            Console.WriteLine("Я бегууу! Мне пора рубить деревья;)");
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
            Console.WriteLine("Рублю деревья");
            if (_hranenie * 10 < _zarobotok)
            {
                _zarobotok += 1;
            }
            else
            {
                Console.WriteLine("Хранение переполнено!");
            }
            if (_zdorove >= 3)
            {
                _zdorove -= 3;
            }
            else
            {
                Console.WriteLine("Я устал, пойду спать - набираться сил ");
            }
        }

        public void Sleep()
        {
            Console.WriteLine("Сегодня был сложный день. Мне стоит вздремнуть! Храа-пыщщ...храа-пыыщ...");
            _zdorove += 4;

        }

        public void Income()
        {
            Console.WriteLine($"Моя зарплата - деревья.\n Сейчас их {_zarobotok}");

        }
    }
}
