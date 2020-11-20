using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev.strategiya
{
    interface Interface1
    {
        const int minSpeed = 0;
        static int maxSpeed = 20;
        void Move();
        string Name { get; set; }

        delegate void MoveHandler(string message);
        event MoveHandler MoveEvent;
    }
}
