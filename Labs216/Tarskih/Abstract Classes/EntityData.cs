using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih.Abstract_Classes
{
    public abstract class EntityData // ================================================ Абстрактный класс с характеристиками существ
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
}
