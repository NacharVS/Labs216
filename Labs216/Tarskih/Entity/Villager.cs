using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih
{
    public class Villager : Abstract_Classes.EntityData, Interfaces.IMoving, Interfaces.IDamaging, Interfaces.IHealing, Interfaces.IMessaging, Interfaces.IGettingDamage // ------------------------------------------------------------------------------------- Житель
    {
        public Villager(int x, int y, int health, int health_regeneration, int speed, int damage_absolute, int damage_value, bool weapon_have, string description_entity, int damage_entering)
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
            Console.WriteLine($"Деревенский житель переместился на {X} и {Y}");
        }
        public void Attack() // --- Нанесение урона
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
        public void GettingDamage() // --- Получение урона
        {
            if (DamageEntering >= 1)
            {
                Health = Health = DamageEntering;
                Console.WriteLine($"Деревенский житель получил урон в {DamageEntering} условных единиц");
            }
        }
        public void Heal() // --- Лечение
        {
            if (Health < 50)
            {
                Console.WriteLine("Происходит регенерация здоровья юнита");
                for (int i = 0; Health != 55; i = i + 1)
                {
                    Health = Health + HealthRegeneration;
                    Console.WriteLine($"Деревенский житель восстанавливает здоровье в {HealthRegeneration} условных единиц");
                }
            }
            else
            {
                Console.WriteLine($"Деревенский житель не требуется в восстановлении здоровья");
            }
        }
        public void Messaging() // --- Отправка сообщения
        {
            Console.WriteLine($"Деревенский житель осуществляет процесс передачи сообщения");
        }
    }
}
