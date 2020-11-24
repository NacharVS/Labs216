using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame.Mirn_jiteli
{
    interface IDeistviya
    {
        public void Eat()
        {
            Console.WriteLine("Pokyshal");
        }
        public void Lechenie()
        {
            Console.WriteLine("Proshol kyrs lecheniya.");
        }
        public void Walking()
        {
            Console.WriteLine("Took a walke.");
        }
    }
}
