using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Tarskih.Interfaces;
using Labs216.Tarskih.Abstract_Classes;

namespace Labs216.Tarskih.Constructions
{
    class House : ConstructionData, IPlace
    {
        public House(int x, int y, int health_building, int place_count)
        {
            X = x;
            Y = y;
            HealthBuilding = health_building;
            PlaceCount = place_count;
        }
        public void Place()
        {
            Console.WriteLine($"Это здание имеет {PlaceCount} мест");
        }
    }
}
