using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Labs216.Tarskih
{
    public class Strategy // Интерфейсы
    {
        interface IChoice // Интерфейс выбора
        {
            public void Choice()
            {
                Console.WriteLine("Осуществите выбор");
            }

        }
        interface IMoving // Интерфейс движения
        {
            public void Moving()
            {
                Console.WriteLine("Происходит перемещение");
            }
        }
        interface IDamaging // Интерфейс нанесения урона
        {
            public void Damaging()
            {
                Console.WriteLine("Происходит нанесение урона");
            }
    }
        interface IHealing // Интерфейс Лечения
        {
            public void Healing()
            {
                Console.WriteLine("Происходит лечение");
            }
        }
        interface IMessaging // Интерфейс передачи сообщения
        {
            public void Messaging()
            {
                Console.WriteLine("Происходит передача сообщения");
            }
        }
        interface IInsiding // Интерфейс нахождения внутри
        {
            public void Insiding()
            {
                Console.WriteLine("Происходит нахождение внутри");
            }
        }
        public abstract class Characteristics // Абстрактный класс с характеристиками
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Health { get; set; }
            public int Speed { get; set; }
            public int DamageAbsolute { get; set; }
            public int DamageValue { get; set; }
            public bool WeaponHave { get; set; }
            public string DescriptionEntity { get; set; }
        }
        public class Villager : Characteristics, IMoving, IDamaging, IHealing
        {
            public Villager(int x, int y, int health, int speed, int damage_absolute, int damage_value, string description_entity, bool weapon_have)
            {
                X = x;
                Y = y;
                Health = health;
                Speed = speed;
                DamageAbsolute = damage_absolute;
                DamageValue = damage_value;
                WeaponHave = weapon_have;
                DescriptionEntity = description_entity;
            }
            public void Moving(int X1, int Y1)
            {
                int X = 0 + X1;
                int Y = 0 + Y1;
                Console.WriteLine($"Деревенский житель переместился на {X} и {Y}");
            }
            public void Attack()
            {
                if (WeaponHave)
                {
                    DamageValue = DamageValue + DamageAbsolute;
                    Console.WriteLine($"Деревенский житель наносит урон в {DamageValue} условных единиц");
                }
                else
                {
                    Console.WriteLine($"Деревенский житель наносит урон в {DamageAbsolute} условных единиц");
                }
            }
        }
    }
}
