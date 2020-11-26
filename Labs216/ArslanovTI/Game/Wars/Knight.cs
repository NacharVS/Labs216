using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game
{
    class Knight : Health, IAttack, IMoveable, IDamage
    {
        public int minDamage => 102;

        public int maxDamage => 201;

        public int minSpeed => 3;

        public int maxSpeed =>7;

        public int _attackrange => 2;

        public int _splashattack => 2;

        public int _attackspeed => 5;

        public void Attack()
        {
            Console.WriteLine("Атака рыцаря!");
        }

        public void Move()
        {
            Console.WriteLine("Рыцарь  отступает!");
        }
    }
}
