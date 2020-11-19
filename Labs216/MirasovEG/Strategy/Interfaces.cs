using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.MirasovEG.Strategy
{
    interface IMovable
    {
        public void Move();
    }
    interface IAttack
    {
        public void MeleeAttack();
    }
    interface IShoot
    {
        public void Shoot();
    }

    interface IWork
    {
        public void Work();
    }

    interface IProfit
    {
        public void Profit();
    }

    interface ICivilian : IMovable, IWork{}
    interface IMultiWarior : IMovable, IAttack, IShoot{}
    interface IMeleeWarior : IMovable, IAttack { }
    interface IDistanceWarior : IMovable, IShoot { }
    interface IBuilding : IProfit { }
    interface IWarBuilding : IShoot{}
    
}
