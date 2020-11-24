using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.warniors
{
    class FootSoldier : Characteristics, IShootable, IMovable
    {
        public void Move()
        {
            Console.WriteLine("FootSoldier moving");
        }
        public void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
