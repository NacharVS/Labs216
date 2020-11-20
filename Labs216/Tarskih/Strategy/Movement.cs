using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih.Strategy
{
    class Movement
    {
        public abstract class MovableObject
        {
            public abstract void Move(int dx, int dy);
            public abstract bool MoveNode(int i, int dx, int dy);
        }
    }

}
