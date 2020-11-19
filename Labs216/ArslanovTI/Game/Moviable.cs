using System;
using System.Collections.Generic;
using System.Text;
using Labs216.ArslanovTI.Archer;

namespace Labs216.ArslanovTI.Game
{
    class Moviable
    {

        interface IMoviable
        {
            static void Move(int speedArcher, int speedWizard, int speedBerserk, int speedVillager, int speedknight)
            {
                speedArcher = 15;
                speedWizard = 10;
                speedBerserk = 9;
                speedVillager = 5;
                speedknight = 11;
            }






        }
    }
}

