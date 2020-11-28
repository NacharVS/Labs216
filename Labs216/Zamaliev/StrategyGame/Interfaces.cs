using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zamaliev.StrategyGame
{
        interface IMovable
        {
        const int minspeed = 0;
        static int maxspeed = 100;
            public void Move();
        int Speed { get; set; }
            
        }
    interface IAttack
    {
        public void Attack();
    }
    interface IShootable
    { 
        public void Shoot();
           
        }
        interface IMinable
        {
            public void Mine();
           
        
        }
        interface IDefense
        {

        }

        
}
