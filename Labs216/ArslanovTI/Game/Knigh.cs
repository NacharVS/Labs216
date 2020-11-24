using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game
{
    class Knight : Health, IAttack, IMoveable
    {
        public int minDamage => 102;

        public int maxDamage => 201;

        public int minSpeed => throw new NotImplementedException();

        public int maxSpeed => throw new NotImplementedException();

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
