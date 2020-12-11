using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih.Abstract_Classes
{
    public abstract class EntityData
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }
        public int Healing { get; set; }
    }
}
