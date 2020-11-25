using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dimukhametov.Strategy
{
    class ArcherTower : BuildCharacteristics, IShoot
        {
            public ArcherTower(int health, int damage, int speed)
            {
                _health = health;
                _damage = damage;
            }

            public void Shoot()
            {
                Console.WriteLine("Выстрелил и нанес урон в значении: {_damage}");
            }
        }
    }
