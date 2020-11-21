using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Strategygame
{
    interface IMovable
    {        
        public void Move();
    }
    interface IShootable
    {
        public void Shoot();
    }
    //interface IWorkers
    //{
    //    public void Work();       /*// Сделать айпродакшн*/
    //}
    interface ICreatable
    {
        public void Construct();
    }
    interface IArmy
    {      
        public void Attack();
    }


    
}
