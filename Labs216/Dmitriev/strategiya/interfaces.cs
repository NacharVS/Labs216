using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev.strategiya
{
    interface Interf
    {
        const int minSpeed = 0;
        static int maxSpeed = 20;
        void Move();
        string Name { get; set; }

        delegate void MoveHandler(string message);
        event MoveHandler MoveEvent;
    }
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

    interface ICivilian : IMovable
    {
        public void Work();
    }

    interface IWarUnit : IMovable
    {
        public int Damage { get; }

        public void Attack();
    }

    interface IBuilding
    {
        public void Interact();
    }
}

