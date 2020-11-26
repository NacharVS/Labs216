using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game
{
    class Berserk : Health, IAttack, IMoveable , IDamage
    {
        public int minSpeed => 2;

        public int maxSpeed => 5;

        public int _attackrange => 3;

        public int _splashattack => 6;

        public int _attackspeed => 4;

        int IAttack.minDamage =>50;
        int minDamage { get => 50; }

        int maxDamage { get => 167; }

        int IAttack.maxDamage => 167;

        public void Attack()
        {
            Console.WriteLine("Атака берсерка");
        }

        public void Move()
        {
            Console.WriteLine("Берсерк отступает");
        }
    }
}
