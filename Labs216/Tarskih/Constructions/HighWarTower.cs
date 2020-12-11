using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Tarskih.Interfaces;
using Labs216.Tarskih.Abstract_Classes;

namespace Labs216.Tarskih.Constructions
{
    class HighWarTower : ConstructionData, IPlace, IShoot
    {
        public HighWarTower(int x, int y, int health_building, int damage_building, int place_count)
        {
            X = x;
            Y = y;
            HealthBuilding = health_building;
            DamageBuilding = damage_building;
            PlaceCount = place_count;
        }
        public void Place()
        {
            Console.WriteLine($"Это здание имеет {PlaceCount} мест");
        }
        public void Shoot()
        {
            Console.WriteLine($"Это здание наносит дальний урон в {DamageBuilding}");
        }
    }
}
