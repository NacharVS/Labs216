using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zamaliev.StrategyGame
{
        interface IMovable
        {
            public void Move();
            
        }
        interface IAttack
        {
            public void Shoot();
            public void Punch();
        }
        interface IMinable
        {
            public void Mine();
            public void ChopWood();
            public void ToFish();
            public void Build();
            public void Farm();
        }
        interface IDefense
        {

        }

        
}
