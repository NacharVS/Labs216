using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Tarskih.Interfaces;
using Labs216.Tarskih.Abstract_Classes;

namespace Labs216.Tarskih.Entity
{
    public class Villager : EntityData, IMove, IAttack
    {
        public Villager(int x, int y, int health, int damage, int speed)
        {
            X = x;
            Y = y;
            Health = health;
            Damage = damage;
            Speed = speed;
        }
        public void Move()
        {
            Console.WriteLine($"Житель перемещается на {Y} {X}, двигаясь со скоростью {Speed}");
        }
        public void Attack()
        {
            Console.WriteLine($"Житель атакует с уроном в {Damage} единиц");
        }
    }
}
