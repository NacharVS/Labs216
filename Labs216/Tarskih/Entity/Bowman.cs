using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih.Entity
{
    public class Bowman : Abstract_Classes.EntityData, Interfaces.IMoving, Interfaces.IDamaging, Interfaces.IHealing, Interfaces.IMessaging, Interfaces.IDistanceDamaging // ------------------------------------------------------------- Лучник
    {
        public Bowman(int x, int y, int health, int health_regeneration, int speed, int damage_absolute, int damage_value, bool weapon_have, bool distance_weapon_have, string description_entity, int damage_entering)
        {
            X = x;
            Y = y;
            Health = health;
            HealthRegeneration = health_regeneration;
            Speed = speed;
            DamageAbsolute = damage_absolute;
            DamageValue = damage_value;
            WeaponHave = weapon_have;
            DistanceWeaponHave = distance_weapon_have;
            DescriptionEntity = description_entity;
            DamageEntering = damage_entering;
        }
        public void Moving(int X1, int Y1) // --- Движение
        {
            int X = 0 + X1;
            int Y = 0 + Y1;
            Console.WriteLine($"Лучник переместился на {X} и {Y}");
        }
        public void Attack() // --- Движение
        {
            if (WeaponHave)
            {
                DamageValue = DamageValue + DamageAbsolute;
                Console.WriteLine($"Лучник наносит урон в {DamageValue} условных единиц");
            }
            else
            {
                Console.WriteLine($"Лучник наносит урон в {DamageAbsolute} условных единиц");
            }
        }
        public void DistanceDamaging() // --- Дистанционный урон
        {
            if (DistanceWeaponHave)
            {
                DamageValue = (DamageAbsolute / DistanceAttack) * 5;
                Console.WriteLine($"Лучник наносит дистанционный урон в {DamageValue} условных единиц");
            }
        }
        public void Heal() // --- Лечение
        {
            if (Health < 50)
            {
                Console.WriteLine("Происходит регенерация здоровья лучника");
                for (int i = 0; Health != 55; i = i + 1)
                {
                    Health = Health + HealthRegeneration;
                    Console.WriteLine($"Лучник восстанавливает здоровье в {HealthRegeneration} условных единиц");
                }
            }
            else
            {
                Console.WriteLine($"Лучник не требуется в восстановлении здоровья");
            }
        }
        public void Messaging() // --- Отправка сообщения
        {
            Console.WriteLine($"Лучник осуществляет процесс передачи сообщения");
        }
    }
}
