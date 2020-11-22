using System;
using System.Collections.Generic;
using System.Text;


namespace Interfase
    //добавление интерфейса 
    //добавление способностей для (Archer, rider)
    //добавлено 
{
    class Move
    {
        interface IMovable: 
        {
           static void Movable(int speedArcher, int speedprostoHuman, int speedRider)
            {
                speedArcher = 10;
                speedprostoHuman = 7;
                speedRider = 20;
            }
        }
    }
}
