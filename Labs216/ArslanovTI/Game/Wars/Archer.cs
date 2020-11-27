using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game
{
    class Archer : Health , IAttack, IMoveable, IDamage
    {
        public int minDamage => 33;

        public int maxDamage => 100;

        public int minSpeed => 3;

        public int maxSpeed => 7;

        public int _attackrange => 10;

        public int _splashattack => 0;

        public int _attackspeed => 4;

        public void Attack()
        {
            Console.WriteLine("Атака лучника!");
        }
        public void Move()
        {
            Console.WriteLine("Лучник отступает!");
        }
        public void DamageSkills(string FireArrow, string ElectricArrow)
        {
            FireArrow = "Противник получает каждую секунду минус 10 здоровья";
            ElectricArrow = "Противник получает электрический разряд";
            

        }
    }
}
