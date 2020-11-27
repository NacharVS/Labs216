using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame.Voen_jiteli
{
    class Soldat : Characteristic, IDlyaVoennogo
    {
            public Soldat(int zdorove, int maxspeed,  int puli )
            {
            _maxspeed = maxspeed;
            _zdorove = zdorove;
            _puli = puli;
            }

        public void Movement()
        {
            Console.WriteLine("Я пошел на пробежку");
            if (_zdorove >= 2)
            {
                Console.WriteLine("Йохооууу... Я занимаюсь спортом. Вот здорово!");
            }
            else
            {
                Console.WriteLine("Стоит поспать, а потом побегаю.");
            }

        }

        public void Shoot()
        {
            Console.WriteLine("Сейчас у нас проходит боевая подготовка. Мы будем учиться стрелять.");
            if (_zdorove>=3 & _puli>=2)
            {
                Console.WriteLine("Пиу-пиу... Прямо в цель!");
            }
            else
            {
                if(_zdorove<3)
                {
                    Console.WriteLine("Я утомился, слеует набраться сил.");
                }
                if(_puli<2)
                {
                    Console.WriteLine("Нужно сходить в часть за пулями.");
                }
            }
        }

        public void Sleep()
        {
            Console.WriteLine("Нам пора спать. Отбой!");
            _zdorove += 4;
        }

        public void Work()
        {
            Console.WriteLine("Я на службе. Мне стоит выполнять данные руководством приказы! \n Сейчас нам нужно подготовиться к параду! ");
            if(_zdorove>=3)
            {
                Console.WriteLine("Я иду маршировать.");
            }
            else
            {
                Console.WriteLine("Я хочу спать!");
            }
        }
    }
}
