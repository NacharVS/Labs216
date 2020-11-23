using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zamaliev.StrategyGame
{
        interface IMovable
        {
            public void Move();
            public int Speed { get; }
        }
        interface IShootable
        {
            public void Shoot();
        }
        interface IMinable
        {
            public void Mine();
        }
        interface IAttack
        {
            public void Attack();
        }
    }
