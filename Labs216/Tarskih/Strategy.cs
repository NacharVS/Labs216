using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Labs216.Tarskih
{
    public class Strategy // ------------------------------------------------------------------------------------------------------------------------------------------------- Стратегия

        // ======================================================================== Интерфейсы ================================================================================================


    {
        interface IChoice // ------------------------------------------------------------------------------------------------------------------------------------------------- Интерфейс выбора
        {
            public void Choice()
            {
                Console.WriteLine("Осуществите выбор");
            }
        }



        interface IMoving // ------------------------------------------------------------------------------------------------------------------------------------------------- Интерфейс движения
        {
            public void Moving()
            {
                Console.WriteLine("Происходит перемещение");
            }
        }



        interface IDamaging // ----------------------------------------------------------------------------------------------------------------------------------------------- Интерфейс нанесения урона
        {
            public void Damaging()
            {
                Console.WriteLine("Происходит нанесение урона");
            }
        }



        interface IGettingDamage // ------------------------------------------------------------------------------------------------------------------------------------------ Интерфейс получения урона
        {
            public void GettingDamage()
            {
                Console.WriteLine("Данный юнит получает урон");
            }
        }


        interface IHealing // ------------------------------------------------------------------------------------------------------------------------------------------------ Интерфейс Лечения
        {
            public void Healing()
            {
                Console.WriteLine("Происходит лечение");
            }
        }



        interface IMessaging // ---------------------------------------------------------------------------------------------------------------------------------------------- Интерфейс передачи сообщения
        {
            public void Messaging()
            {
                Console.WriteLine("Происходит передача сообщения");
            }
        }



        interface IInsiding // ----------------------------------------------------------------------------------------------------------------------------------------------- Интерфейс нахождения внутри
        {
            public void Insiding()
            {
                Console.WriteLine("Происходит нахождение внутри");
            }
        }



        interface IShieldProtection // -------------------------------------------------------------------------------------------------------------------------------------- Интерфейс защиты щитом
        {
            public void ShieldProtection()
            {
                Console.WriteLine("Щит данного юнита поглощает часть урона");
            }
        }
        


        interface IDistanceDamaging // --------------------------------------------------------------------------------------------------------------------------------------- Дистанционная атака
        {
            public void DistanceAttack()
            {
                Console.WriteLine("Данный юнит совершает атаку на расстоянии");
            }
        }



        interface IDowning // ------------------------------------------------------------------------------------------------------------------------------------------------ Оглушение
        {
            public void Downing()
            {
                Console.WriteLine("Данный юнит совершает оглушение");
            }
        }



        interface IWorking // ------------------------------------------------------------------------------------------------------------------------------------------------ Работа или добыча
        {
            public void Working()
            {
                Console.WriteLine("Данный юнит совершает работу или добычу");
            }
        }



        interface IResting // ------------------------------------------------------------------------------------------------------------------------------------------------ Отдых
        {
            public void Resting()
            {
                Console.WriteLine("Данный юнит отдыхает");
            }
        }



        public abstract class EntityData // ================================================================================================================================ Абстрактный класс с характеристиками
        {
            public int X { get; set; } // Положение по оси Х
            public int Y { get; set; } // Положение по оси У
            public int Health { get; set; } // Здоровье
            public int HealthRegeneration { get; set; } // Скорость Регенерации
            public int Speed { get; set; } // Скорость
            public int DamageAbsolute { get; set; } // Абсолютный Урон
            public int DamageValue { get; set; } // Полный Урон
            public int DistanceAttack { get; set; } // Дистанционный Урон
            public bool WeaponHave { get; set; } // Имение оружия
            public bool DistanceWeaponHave { get; set; } // Имение дистанцинного оружия
            public string DescriptionEntity { get; set; } // Описание
            public int DamageEntering { get; set; } // Получаемый Урон
            public bool DowningAbility { get; set; } // Способность Оглушения
            public int DowningTime { get; set; } // Время Оглушения
            public bool WorkAbility { get; set; } // Способность Работы
            public int WorkEnergy { get; set; } // Энергия Работы
            public int TotalWorkEnergy { get; set; } // Полная Энергия
            public int WorkEnergyRegeneration { get; set; } // Восстановление Энергии
            public int MaterialCount { get; set; } // Полное количество материала
            public int MaterialExtractionCount { get; set; } // Добыча Материала
        }
            


        // ============================================================================ Юниты - Существа ====================================================================================


        public class Villager : EntityData, IMoving, IDamaging, IHealing, IMessaging, IGettingDamage // ------------------------------------------------------------------------------------- Житель
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
                    for ( int i = 0; Health != 55; i = i + 1 )
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



        public class Guardian : EntityData, IMoving, IDamaging, IHealing, IMessaging, IShieldProtection // ----------------------------------------------------------------- Страж
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



        public class Bowman : EntityData, IMoving, IDamaging, IHealing, IMessaging, IDistanceDamaging // ----------------------------------------------------------------- Лучник
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



        public class HeavyGuardian : EntityData, IMoving, IDamaging, IHealing, IMessaging, IGettingDamage, IDowning // ------------------------------------------------------------------------------------- Тяжёлый страж
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



        public class Earner : EntityData, IMoving, IDamaging, IHealing, IMessaging, IGettingDamage, IWorking, IResting // ------------------------------------------------------------------------------------- Добытчик
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
}

