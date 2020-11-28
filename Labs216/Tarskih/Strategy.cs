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



        public abstract class EntityData // ================================================================================================================================ Абстрактный класс с характеристиками существ
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



        interface ICRestingPlace // ------------------------------------------------------------------------------------------------------------------------------------------- Место для отдыха
        {
            public void CRestingPlace()
            {
                Console.WriteLine("В этом строении есть место или несколько мест для отдыха");
            }
        }



        interface ICDefendingPlace // ----------------------------------------------------------------------------------------------------------------------------------------- Защита строения
        {
            public void CDefendingPlace()
            {
                Console.WriteLine("С этого строения идёт внутренняя защита");
            }
        }



        interface ICGettingDamagePlace // -------------------------------------------------------------------------------------------------------------------------------------- Получение урона строением
        {
            public void CGettingDamagePlace()
            {
                Console.WriteLine("Это строение получает урон");
            }
        }



        interface ICRestorationPlace // ----------------------------------------------------------------------------------------------------------------------------------------- Восстановление строения
        {
            public void CRestorationPlace()
            {
                Console.WriteLine("Это строение восстанавливается");
            }
        }



        interface ICSafeKeeping // ----------------------------------------------------------------------------------------------------------------------------------------- Хранилище строения
        {
            public void CSafeKeeping()
            {
                Console.WriteLine("Это строение что-то в себе хранит");
            }
        }



        interface ICDestruction // ----------------------------------------------------------------------------------------------------------------------------------------- Разрушение здания
        {
            public void Destruction()
            {
                Console.WriteLine("Состояние здания");
            }
        }



        public abstract class ConstructionData // ============================================================================================================================= Абстрактный класс с характеристиками строений
        {
            public int X { get; set; } // Положение по оси Х
            public int Y { get; set; } // Положение по оси У
            public int MaxDurabilty { get; set; } // Максимальная прочность - константа
            public int Durabilty { get; set; } // Прочность
            public int PlaceCount { get; set; } // Количество мест
            public int RestPlaceCount { get; set; } // Количество мест для отдыха
            public bool RestingPlace { get; set; } // Возможность отдыха в этом строении
            public bool DefendingPlace { get; set; } // Возможность защиты этого строения
            public string DescriptionConstruction { get; set; } // Описание строения
            public int RestorationPlace { get; set; } // Восстановление строения
            public int TakeMaterialCountPlace { get; set; } // Хранилище материала строением
            public int CurrentMaterialCountPlace { get; set; } // Текущее количество материала в хранилище
            public int MaxMaterialCountPlace { get; set; } // Максимальное количество материала в строении
            public int GettingDamagePlace { get; set; } // Получение урона строением
        }
            



        // ============================================================================= Юниты - Строения ====================================================================================================================




        public class Cottage : ConstructionData, ICRestingPlace, ICSafeKeeping, ICGettingDamagePlace, ICDefendingPlace, ICRestorationPlace, ICDestruction // --------------------------------------------------- Хижина
        {
            public Cottage(int x, int y, int durability, int place_count, int rest_place_count, bool resting_place, bool defending_place, string description_construction, int restoration_place, int current_material_count_place, int max_material_count_place, int take_material_count_place, int getting_damage_place, int max_durability)
            {
                X = x;
                Y = y;
                Durabilty = durability;
                PlaceCount = place_count;
                RestPlaceCount = rest_place_count;
                RestingPlace = resting_place;
                DefendingPlace = defending_place;
                DescriptionConstruction = description_construction;
                RestorationPlace = restoration_place;
                TakeMaterialCountPlace = take_material_count_place;
                MaxMaterialCountPlace = max_material_count_place;
                CurrentMaterialCountPlace = current_material_count_place;
                GettingDamagePlace = getting_damage_place;
                MaxDurabilty = max_durability;
            }
            public void CRestingPlace(int a)
            {
                if (RestingPlace)
                {
                    if (RestPlaceCount != 0)
                    {
                        Console.WriteLine("В этой хижине есть место для отдыха. Занять его? ( да = 1, нет = 2)");
                        if (a == 1)
                        {
                            RestPlaceCount = RestPlaceCount - 1;
                            Console.WriteLine("В этой хижине было занято место для отдыха");
                        }
                        else if (a == 2)
                        {
                            RestPlaceCount = RestPlaceCount;
                            Console.WriteLine("В этой хижине не было занято место для отдыха");
                        }
                    }
                    else
                    {
                        Console.WriteLine("В этой хижине нет свободных мест для отдыха");
                    }
                }
                else
                {
                    Console.WriteLine("В этой хижине не может быть мест для отдыха");
                }
            }
            public void CDefending()
            {
                if (DefendingPlace)
                {
                    Console.WriteLine("С этой хижины может осуществляться защита");
                }
            }
            public void CGettingDamage()
            {
                if (GettingDamagePlace != 0)
                {
                    Durabilty = Durabilty - GettingDamagePlace;
                    Console.WriteLine("Эта хижина получает урон");
                }
                else
                {
                   
                }
            }
            public void CDestruiction()
            {
                if (Durabilty <= 0)
                {
                    Console.WriteLine("Эта хижина разрушена");
                }
                else
                {
                    Console.WriteLine("Эта хижина не разрушено");
                }
            }
            public void CRestoration(int b)
            {
                if (Durabilty !<= 0)
                {
                    Console.WriteLine("Эта хижина может быть восстановлено ( да = 1, нет = любая клавиша)");
                    if (b == 1)
                    {
                        if (Durabilty != MaxDurabilty)
                        {
                            Durabilty = Durabilty + RestorationPlace;
                            Console.WriteLine($"Эта хижина восстанавливается на {RestorationPlace} единиц");
                        }
                        else
                        {
                            Console.WriteLine("Эта хижина не требуется в восстановлении");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Был выбран вариант не восстанавливать хижину");
                    }
                }
                else
                {
                    Console.WriteLine("Эта хижина не может быть восстановлена, так как она уничтожена");
                }
            }
            public void CSafeKeeping(int c)
            {
                if (CurrentMaterialCountPlace != MaxMaterialCountPlace)
                {
                    Console.WriteLine("Сложить в эту хижину материал? ( да = 1, нет = любая клавиша");
                    if (c == 1)
                    {
                        CurrentMaterialCountPlace = CurrentMaterialCountPlace + TakeMaterialCountPlace;
                        Console.WriteLine($"В эту хижину было вложено {TakeMaterialCountPlace} материала");
                    }
                    else
                    {
                        Console.WriteLine("В хижину не было вложен материал");
                    }
                }
                else
                {
                    Console.WriteLine("Хранилище в хижине переполнено! Она не может получить больше материала!");
                }
            }
        }
    }
}

