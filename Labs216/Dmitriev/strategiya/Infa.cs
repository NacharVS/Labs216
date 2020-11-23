using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev.strategiya
{
    class Infa
    {
        public abstract class infa4ela
        {
            public int _health { get; set; }
            public int _defense { get; set; }
            public int _DMG { get; set; }
            public int _speed { get; set; }
        }

        public abstract class infaBuilding
        {
            public int _health { get; set; }
            public int _defense { get; set; }
            public int _dmgBuild { get; set; }
            public bool IsDestroyed { get; set; }
        }
    }

}
}
