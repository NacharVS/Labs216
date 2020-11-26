using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame.Voen_jiteli
{
    class Soldat : Characteristic, IDlyaVoennogo
    {

        public void Movement()
        {
            
        }

        public void Shoot()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Я на службе. Мне стоит выполнять данные руководством приказы!");
        }
    }
}
