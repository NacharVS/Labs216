using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame
{
    interface IShoot
    {
        //srtelyat
        public void Shoot();
    }
    interface IMovement
    {
        //peredvigenie
        public void Movement();
    }
    interface ICharge
    {
        //zaryad, ataka
        public void Charge();
    }
    interface IRevive
    {
        //ozhivat'
        public void Revive();
    }
    interface ITreat
    {
        //lechit'
        public void Treat();
    }
    interface IIncome
    {
        //pribbIl'
        public void Income();
    }

    interface IWork
    {
        //pabota
        public void Work();
    }


}

