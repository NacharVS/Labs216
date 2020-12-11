using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Tarskih.Interfaces;
using Labs216.Tarskih.Abstract_Classes;

namespace Labs216.Tarskih.Constructions
{
    class Warehouse : ConstructionData, IPlace, IStore
    {
        public Warehouse(int x, int y, int health_building, int place_count, int material_count)
        {
            X = x;
            Y = y;
            HealthBuilding = health_building;
            PlaceCount = place_count;
            MaterialCount = material_count;
        }
        public void Place()
        {
            Console.WriteLine($"Это здание имеет {PlaceCount} мест");
        }
        public void Store()
        {
            Console.WriteLine($"Это здание содержит {MaterialCount} материала");
        }
    }
}
