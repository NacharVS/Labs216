using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Strategygame
{
    public class RunGame
    {
        public static void Run()
        {
            IMovable move;
            IAttack attack;
            IShootable shoot;            
            IGather gatherer;

            var farmer = new Farmer(12, 12);

            move = farmer;
            move.Move();

           

        }

    }
}
