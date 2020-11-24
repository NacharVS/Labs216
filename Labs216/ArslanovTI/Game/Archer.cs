using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game
{
    class Archer : Health , IAttack, IMoveable
    {
        public int minDamage => 33;

        public int maxDamage => 100;

        public int minSpeed => 3;

        public int maxSpeed => 7;

        public void Attack()
        {
            throw new NotImplementedException();
        }
        public void Move()
        {
            throw new NotImplementedException();
        }
        public void DamageSkills(int FireArrow, int ElectricArrow)
        {
            FireArrow = 100;
            ElectricArrow = 500;

        }
    }
}
