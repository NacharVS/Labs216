using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Tarskih.Interfaces;
using Labs216.Tarskih.Abstract_Classes;

namespace Labs216.Tarskih.Entity
{
    class Engineer : EntityData, IMove, IAttack, IBuild
    {
        public Engineer(int x, int y, int health, int damage, int speed, int healing)
        {
            X = x;
            Y = y;
            Health = health;
            Damage = damage;
            Speed = speed;
            Healing = healing;
        }
        public void Move()
        {
            Console.WriteLine($"Инженер перемещается на {Y} {X}, двигаясь со скоростью {Speed}");
        }
        public void Attack()
        {
            Console.WriteLine($"Инженер атакует с уроном в {Damage} единиц");
        }
        public void Build()
        {
            Console.WriteLine($"Инженер что-то ремонтирует");
        }
    }
}
