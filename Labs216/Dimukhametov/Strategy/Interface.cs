using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dimukhametov.Strategy
{
    interface IMovable
    {
        public void Move();
        public int _speed { get; set; }
    }
    interface IAttack
    {
        public void Attack();
    }
    interface IShoot
    {
        public void Shoot();
    }
    interface IWork
    {
        public void work();
    }
    interface IBuild
    {
        public void Build();
    }
}
