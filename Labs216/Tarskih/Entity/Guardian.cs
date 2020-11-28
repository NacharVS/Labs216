using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih
{
    public class Guardian : Abstract_Classes.EntityData, Interfaces.IMoving, Interfaces.IDamaging, Interfaces.IHealing, Interfaces.IMessaging, Interfaces.IShieldProtection // ----------------------------------------------------------------- Страж
    {
        public Guardian(int x, int y, int health, int health_regeneration, int speed, int damage_absolute, int damage_value, bool weapon_have, string description_entity, int damage_entering)
        {
            X = x;
            Y = y;
            Health = health;
            HealthRegeneration = health_regeneration;
            Speed = speed;
            DamageAbsolute = damage_absolute;
            DamageValue = damage_value;
            WeaponHave = weapon_have;
            DescriptionEntity = description_entity;
            DamageEntering = damage_entering;
        }
        public void Moving(int X1, int Y1) // --- Движение
        {
            int X = 0 + X1;
            int Y = 0 + Y1;
            Console.WriteLine($"Страж переместился на {X} и {Y}");
        }
        public void Attack() // --- Движение
        {
            if (WeaponHave)
            {
                DamageValue = DamageValue + DamageAbsolute;
                Console.WriteLine($"Страж наносит урон в {DamageValue} условных единиц");
            }
            else
            {
                Console.WriteLine($"Страж наносит урон в {DamageAbsolute} условных единиц");
            }
        }
        public void ShieldProtection() // --- Получение урона со сдерживанием части урона щитом
        {
            if (DamageEntering >= 1 & DamageEntering < 90)
            {
                DamageEntering = DamageEntering / 2;
                Health = Health - DamageEntering;
                Console.WriteLine($"Щит стража сдержал часть урона, но стражем был получен урон в {DamageEntering} условных единиц");
            }
        }
        public void Heal() // --- Лечение
        {
            if (Health < 50)
            {
                Console.WriteLine("Происходит регенерация здоровья стража");
                for (int i = 0; Health != 55; i = i + 1)
                {
                    Health = Health + HealthRegeneration;
                    Console.WriteLine($"Страж восстанавливает здоровье в {HealthRegeneration} условных единиц");
                }
            }
            else
            {
                Console.WriteLine($"Страж не требуется в восстановлении здоровья");
            }
        }
        public void Messaging() // --- Отправка сообщения
        {
            Console.WriteLine($"Страж осуществляет процесс передачи сообщения");
        }
    }
}
