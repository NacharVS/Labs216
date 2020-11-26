using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game
{
    class Wizard : Health, IAttack, IMoveable, IDamage
    {
        public int minDamage => 145;

        public int maxDamage => 250;

        public int minSpeed =>4;

        public int maxSpeed => 7;

        public int _attackrange => 10;

        public int _splashattack => 7;

        public int _attackspeed => 10;

        public void Attack()
        {
            Console.WriteLine("Атака мага!");
        }

        public void Move()
        {
            Console.WriteLine("Маг отступает!");
        }
    }
}
