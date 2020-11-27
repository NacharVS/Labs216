using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame.Voen_jiteli
{
    class Praporchik : Characteristic, IDlyaVoennogo
    {
        public Praporchik(int zdorove,  int maxspeed)
        {
            _maxspeed = maxspeed;
            _zdorove = zdorove;
        }
        public void Movement()
        {
            Console.WriteLine("Я пошел отдавать приказы солтатам!");
            if(_zdorove>=2)
            {
                _zdorove -= 2;
                Console.WriteLine("Солдаты от руководства поступило распоряжение \n по устранению замечаний на складах боеприпасов," +
                    "\n местах хранения лекарств. ");
                Console.WriteLine("К работе приступили!");
            }
            else
            {
                Console.WriteLine("Посплю и пойду командывать.");
            }
        }

        public void Shoot()
        {
            Console.WriteLine("Бандитыыы... Караул, спасайся кто может. ");
            if(_zdorove>=5)
            {
                _zdorove -= 5;
                Console.WriteLine("Получите... Так вам и надо...  Быдыщ-дыщ-дыщ...");
            }
            else
            {
                Console.WriteLine("Помогитеее, у меня нет сил. Я в ауте");
            }
        }

        public void Sleep()
        {
            Console.WriteLine("На складе порядок, все дела сделал! Пора спать.");
            _zdorove += 3;
        }

        public void Work()
        {
            Console.WriteLine("В мои обязанности входит управление складом,\n обеспечение чистоты на рабочем участке ");
            if (_zdorove>=2)
            {
                _zdorove -= 2;
                Console.WriteLine("Товарищ, командир, на сегодня все задачи выполненны.\n Я пошел домой! ");
            }

        }
    }
}
