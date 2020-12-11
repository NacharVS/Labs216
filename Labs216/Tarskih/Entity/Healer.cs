using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Tarskih.Interfaces;
using Labs216.Tarskih.Abstract_Classes;

namespace Labs216.Tarskih.Entity
{
    class Healer : EntityData, IMove, IAttack, IHeal
    {
        public Healer(int x, int y, int health, int damage, int speed, int healing)
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
            Console.WriteLine($"Целитель перемещается на {Y} {X}, двигаясь со скоростью {Speed}");
        }
        public void Attack()
        {
            Console.WriteLine($"Целитель атакует с уроном в {Damage} единиц");
        }
        public void Heal()
        {
            Console.WriteLine($"Целитель лечит, восстанавливая {Healing} очков здоровья");
        }
    }
}
