using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dimukhametov.Strategy
{
    class Wizard : Characteristics, IMovable, IShoot
    {
        public Wizard(int health, int damage, int speed)
        {
            _health = health;
            _damage = damage;
            _speed = speed;
        }
        public void Move()
        {
            Console.WriteLine("Двигаюсь к экзамену со скоростью: {_speed}");
        }

        public void Shoot()
        {
            Console.WriteLine("Выстрелил и нанес урон в значении: {_damage}");
        }
    }
}
