using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev.strategiya.Infa
{
    public abstract class infa4ela
    {
        public int _Zdorove { get; set; }
        public int _Oborona { get; set; }
        public int _uron { get; set; }
        public int _speed { get; set; }
    }

    public abstract class infaBuilding
    {
        public int _Zdorove { get; set; }
        public int _Oborona { get; set; }
        public int _uron { get; set; }
        public bool Razrushen { get; set; }
    }
    public abstract class Characteristics
    {
        public int Health { get; set; }
    }
}

}

