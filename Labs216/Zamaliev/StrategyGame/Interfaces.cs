using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zamaliev.StrategyGame
{
    class Interfaces
    {
        interface IMovable
        {
            public void Move();
        }
        interface IShootable
        {
            public void Shoot();
        }
    }
}
