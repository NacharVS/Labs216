using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.warniors
{
    class ninja : Characteristics, IShootable, IMovable
    {
        public void Move()
        {
            Console.WriteLine("ninja moving");
        }
        public void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
