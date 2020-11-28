using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih.Abstract_Classes
{
    public abstract class ConstructionData // =========================================== Абстрактный класс с характеристиками строений
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
}
