using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Tarskih.Interfaces;
using Labs216.Tarskih.Abstract_Classes;

namespace Labs216.Tarskih.Entity
{
    class HeavyGuardian : EntityData, IMove, IAttack, IHit
    {
        public HeavyGuardian(int x, int y, int health, int damage, int speed, int armor)
        {
            X = x;
            Y = y;
            Health = health;
            Damage = damage;
            Speed = speed;
            Armor = armor;
        }
        public void Move()
        {
            Console.WriteLine($"Тяжёлый Страж перемещается на {Y} {X}, двигаясь со скоростью {Speed}");
        }
        public void Attack()
        {
            Console.WriteLine($"Тяжёлый Страж атакует с уроном в {Damage} единиц");
        }
        public void Hit()
        {
            Console.WriteLine($"Тяжёлый Страж наносит атаку с оглушением с уроном в {Damage} единиц");
        }
    }
}
