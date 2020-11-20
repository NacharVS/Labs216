using System;
using System.Collections.Generic;
using System.Text;


namespace Labs216.Shakirov.Game
{
    class Movable
    {
        interface IMovable
        {
            static void Move(int speedArcher, int speedWizard, int speedNinja, int speedknight)
            {
                speedArcher = 20;
                speedWizard = 16;
                speedNinja = 35;
                speedknight = 13;
            }
        }
    }
}
