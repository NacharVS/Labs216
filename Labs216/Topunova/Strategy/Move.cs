using System;
using System.Collections.Generic;
using System.Text;

namespace Interfase

{
    class Move
    {
        interface Movable
        {
           static void IMovable(int speedArcher, int speedprostoHuman, int speedRider)
            {
                speedArcher = 10;
                speedprostoHuman = 7;
                speedRider = 20;
            }
        }
    }
}
