using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih.Strategy
    {
        class Units
        {
            public abstract class MovableObject
            {
                public abstract void Move(int dx, int dy);
                public abstract bool MoveNode(int i, int dx, int dy);
            }
            public interface iVillager
            {
                int GetVillager(int health = 100, int armor = 0, int craft = 1, int medication = 1)
                    int Stats { get; set; }
            }
        }
    }
}
}
