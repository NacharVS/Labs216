using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Strategygame
{
    public class RunGame
    {
        public static void Run()
        {
            var farmer1 = TeachFarmer();
            IMovable move = farmer1;
            move.Move();
            IGather gather = farmer1;
            gather.Gather();
        }
        public static Farmer TeachFarmer()
        {
            Farmer farmerUnit = new Farmer(1, 1);
            return farmerUnit;
        }
    }
}
