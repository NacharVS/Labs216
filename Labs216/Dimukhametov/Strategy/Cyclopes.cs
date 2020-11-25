using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dimukhametov.Strategy
{
    class Cyclop : Characteristics, IMovable, IAttack
    {
        public Cyclop(int health, int damage, int speed)
        {
            _health = health;
            _damage = damage;
            _speed = speed;
        }
        public void Move()
        {
            Console.WriteLine("Двигаюсь к экзамену со скоростью: {_speed}");
        }

        public void Attack()
        {
            Console.WriteLine("Бью с силой: {_damage}");
        }
    }

}