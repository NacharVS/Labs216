using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova
{
    interface Iworkers
    {
        public void Cook();
        public void Move();
        public void Sleep();
        public void Eat();
    }
    interface Iwariors
    {
        public void Stun();
        public void Grenade();
        public void Axe();
    }
    interface IBuildings
    { 
        public void Collabaration();
    }
}
