using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Strategygame
{
    interface IMovable
    {
        public int Speed { get; }
        public void Move();
    }
    interface IShootable
    {
        public void Shoot();
    }
       interface IGather
    {
        public void Gather();
    }
    interface IArmy
    {      
        public void Attack();
    }


    
}
