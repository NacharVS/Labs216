using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game
{
    class Berserk : Health, IAttack, IMoveable 
    {
        public int minSpeed => 2;

        public int maxSpeed => 5;

        int IAttack.minDamage =>50;
        int minDamage { get => 50; }

        int maxDamage { get => 167; }

        int IAttack.maxDamage => 167;

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
