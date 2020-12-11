using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih.Abstract_Classes
{
    public abstract class ConstructionData
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int HealthBuilding { get; set; }
        public int DamageBuilding { get; set; }
        public int PlaceCount { get; set; }
        public int MaterialCount { get; set; }
    }
}
