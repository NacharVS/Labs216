using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game
{
    class Villager : Health, IAttack, IMoveable
    {
        public int minDamage => 1;

        public int maxDamage => 2;

        public int minSpeed => 3;

        public int maxSpeed => 5;

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
