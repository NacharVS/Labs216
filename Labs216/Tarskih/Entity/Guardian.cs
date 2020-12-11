using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Tarskih.Interfaces;
using Labs216.Tarskih.Abstract_Classes;

namespace Labs216.Tarskih.Entity
{
    class Guardian : EntityData, IMove, IAttack
    {
        public Guardian(int x, int y, int health, int damage, int speed, int armor)
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
            Console.WriteLine($"Страж перемещается на {Y} {X}, двигаясь со скоростью {Speed}");
        }
        public void Attack()
        {
            Console.WriteLine($"Страж атакует с уроном в {Damage} единиц");
        }
    }
}
