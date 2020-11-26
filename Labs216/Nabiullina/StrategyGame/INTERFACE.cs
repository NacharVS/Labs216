using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame
{
    interface IDlyaChelovekaMirn
    {
        public void Sleep();
        public void Work();
        public void Income();
        public void Movement();

    }
    interface IDlyaVoennogo
    {
        public void Sleep();
        public void Shoot();
        public void Movement();
        public void Work();
    }
    interface IDlyaZdaniya
    {
        public void ChtoHranitca();
        public void ChisloChelovek();
    }
}

