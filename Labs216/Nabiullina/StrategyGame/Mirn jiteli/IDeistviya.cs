using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame.Mirn_jiteli
{
    interface IEat
    {
        public void Eat()
        {
            Console.WriteLine("Pokyshal");
        }
    }
    interface ILechenie
    {
        public void Lechenie()
        {
            Console.WriteLine("Proshol kyrs lecheniya");
        }
    }
    interface IWalking
    {
        public void Walking()
        {
            Console.WriteLine("Took a walke");
        }
    }
}
