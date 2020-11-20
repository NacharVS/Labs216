using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Strategy
{
    class Interface
    {
        interface IMovable
        {
            public double Speed { get; }
            public double UnitTipe { get; }
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
        interface IBiildings : IShootable
        {
            public void Create();
        }
        interface IFarm
        {
            public void Farm();
        }
        interface IArmy : IMovable , IShootable
        {
            public int Damage { get; }
            public void Attack();
        }
    }
}
