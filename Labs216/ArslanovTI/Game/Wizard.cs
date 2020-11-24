using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game
{
    class Wizard : Health, IAttack, IMoveable
    {
        public int minDamage => 145;

        public int maxDamage => 250;

        public int minSpeed =>4;

        public int maxSpeed => 7;

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
