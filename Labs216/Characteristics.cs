using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216
{
    abstract class Characteristics
    {
        public int _health;
        public int _uron;
        public int _force;
        public int _adroitnes; // ловкость
        public int _success;
        public int _malice; // злость
        public int _intuition;
        public int _attention;
        public int _beauty;
    }
    abstract class CharacteristicsBuildings
    {
        public int _health;
        public int _defence;
    }
    abstract class CharacteristicsWorkers
    {
        public int _health;
        public int _uron;
        public int _skilled; // квалифицированный
        public int _responsibility;
    }
}
