using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih.Interfaces
{
    interface IMove
    {
        public void Move();
    }
    interface IHeal
    {
        public void Heal();
    }
    interface IAttack
    {
        public void Attack();
    }
    interface IShoot
    {
        public void Shoot();
    }
    interface IBuild
    {
        public void Build();
    }
    interface IPlace
    {
        public void Place();
    }
    interface IStore
    {
        public void Store();
    }
    interface IHit
    {
        public void Hit();
    }
}
