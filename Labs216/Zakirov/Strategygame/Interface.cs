using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Strategygame
{
    interface IMovable
    {
        public double Speed { get; }
        public string UnitType { get; }
        public void Move();

    }
    interface IShootable
    {
        public int ShootDamage { get; }
        public int Distance { get; }
        public void Shoot();

    }
    interface IWorkers : IMovable
    {
        public void Work();
    }
    interface IBuilding
    {
        public void Interact();
    }
    interface IArmy : IMovable
    {
        public int Damage { get; }
        public void Attack();
    }


    
}
