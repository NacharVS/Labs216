using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game
{
    interface IMoveable
    {
        public int minSpeed { get; }

        public int maxSpeed { get; }
        void Move();
    }
}
