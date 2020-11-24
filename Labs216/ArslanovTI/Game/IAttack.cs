using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game
{
    interface IAttack
    {
        public  int minDamage { get;}

        public int maxDamage { get; }
        void Attack();
        //111



    }
}
