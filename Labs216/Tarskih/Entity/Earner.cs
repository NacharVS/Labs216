using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih.Entity
{
    public class Earner : Abstract_Classes.EntityData, Interfaces.IMoving, Interfaces.IDamaging, Interfaces.IHealing, Interfaces.IMessaging, Interfaces.IGettingDamage, Interfaces.IWorking, Interfaces.IResting // -------------------------------------------------------------------------------- Добытчик
    {
        public Earner(int x, int y, int health, int health_regeneration, int speed, int damage_absolute, int damage_value, bool weapon_have, string description_entity, int damage_entering, bool working_ability, int material_count, int material_extraction_count, int working_energy, int total_work_energy, int work_energy_regeneration)
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
            WorkAbility = working_ability;
            MaterialCount = material_count;
            MaterialExtractionCount = material_extraction_count;
            WorkEnergy = working_energy;
            TotalWorkEnergy = total_work_energy;
            WorkEnergyRegeneration = work_energy_regeneration;
        }
        public void Moving(int X1, int Y1) // --- Движение
        {
            int X = 0 + X1;
            int Y = 0 + Y1;
            Console.WriteLine($"Добытчик переместился на {X} и {Y}");
        }
        public void Attack() // --- Нанесение урона
        {
            if (WeaponHave)
            {
                DamageValue = DamageValue + DamageAbsolute;
                Console.WriteLine($"Добытчик наносит урон в {DamageValue} условных единиц");
            }
            else
            {
                Console.WriteLine($"Добытчик наносит урон в {DamageAbsolute} условных единиц");
            }
        }
        public void Working() // --- Добыча
        {
            if (WorkAbility & TotalWorkEnergy <= 5)
            {
                MaterialCount = MaterialCount + MaterialExtractionCount;
                Console.WriteLine($"Добытчик извлёк {MaterialExtractionCount} количество материала, накопив всего {MaterialCount} материала");
                TotalWorkEnergy = TotalWorkEnergy - WorkEnergy;
                Console.WriteLine($"Добытчик потратил на добычу материала {WorkEnergy}. Всего у добытчика осталось {TotalWorkEnergy}");
            }
            else
            {
                Console.WriteLine($"Добытчик слишком устал, ему стоит отдохнуть");
            }
        }
        public void Resting() // --- Отдых
        {
            if (WorkAbility & TotalWorkEnergy != 100)
            {
                TotalWorkEnergy = TotalWorkEnergy + WorkEnergyRegeneration;
                if (TotalWorkEnergy >= 100)
                    Console.WriteLine($"Добытчик полностью отдохнул и полность готов к работе!");
            }
            else
            {
                Console.WriteLine($"Добытчик не хочет отдыхать, добытчик хочет работать");
            }

        }
        public void GettingDamage() // --- Получение урона
        {
            if (DamageEntering >= 1)
            {
                Health = Health = DamageEntering;
                Console.WriteLine($"Добытчик получил урон в {DamageEntering} условных единиц");
            }
        }
        public void Heal() // --- Лечение
        {
            if (Health < 50)
            {
                Console.WriteLine("Происходит регенерация здоровья добытчик");
                for (int i = 0; Health != 55; i = i + 1)
                {
                    Health = Health + HealthRegeneration;
                    Console.WriteLine($"Добытчик восстанавливает здоровье в {HealthRegeneration} условных единиц");
                }
            }
            else
            {
                Console.WriteLine($"Добытчик не требуется в восстановлении здоровья");
            }
        }
        public void Messaging() // --- Отправка сообщения
        {
            Console.WriteLine($"Добытчик осуществляет процесс передачи сообщения");
        }
    }
}
