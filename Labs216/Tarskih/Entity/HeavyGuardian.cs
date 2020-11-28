using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih.Entity
{
    public class HeavyGuardian : Abstract_Classes.EntityData, Interfaces.IMoving, Interfaces.IDamaging, Interfaces.IHealing, Interfaces.IMessaging, Interfaces.IGettingDamage, Interfaces.IDowning // --------------------------------------------------------------------------------- Тяжёлый страж
    {
        public HeavyGuardian(int x, int y, int health, int health_regeneration, int speed, int damage_absolute, int damage_value, bool weapon_have, string description_entity, int damage_entering, bool downing_ability, int downing_time)
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
            DowningAbility = downing_ability;
            DowningTime = downing_time;
        }
        public void Moving(int X1, int Y1) // --- Движение
        {
            int X = 0 + X1;
            int Y = 0 + Y1;
            Console.WriteLine($"Тяжёлый страж переместился на {X} и {Y}");
        }
        public void Attack() // --- Нанесение урона
        {
            if (WeaponHave)
            {
                DamageValue = DamageValue + DamageAbsolute;
                Console.WriteLine($"Тяжёлый страж наносит урон в {DamageValue} условных единиц");
            }
            else
            {
                Console.WriteLine($"Тяжёлый страж наносит урон в {DamageAbsolute} условных единиц");
            }
        }
        public void ShieldProtection() // --- Получение урона со сдерживанием части урона щитом
        {
            if (DamageEntering >= 1 & DamageEntering < 90)
            {
                DamageEntering = DamageEntering / 2;
                Health = Health - DamageEntering;
                Console.WriteLine($"Щит тяжёлого стража сдержал часть урона, но тяжёлым стражем был получен урон в {DamageEntering} условных единиц");
            }
        }
        public void Downing()
        {
            if (DowningAbility)
            {
                Console.WriteLine($"Тяжёлый страж оглушил противника на {DowningTime} единиц времени");
            }
        }
        public void Heal() // --- Лечение
        {
            if (Health < 50)
            {
                Console.WriteLine("Происходит регенерация здоровья тяжёлого стража");
                for (int i = 0; Health != 55; i = i + 1)
                {
                    Health = Health + HealthRegeneration;
                    Console.WriteLine($"Тяжёлый страж восстанавливает здоровье в {HealthRegeneration} условных единиц");
                }
            }
            else
            {
                Console.WriteLine($"Тяжёлый страж не требуется в восстановлении здоровья");
            }
        }
        public void Messaging() // --- Отправка сообщения
        {
            Console.WriteLine($"Тяжёлый страж осуществляет процесс передачи сообщения");
        }
    }
}
