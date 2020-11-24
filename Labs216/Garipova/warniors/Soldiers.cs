using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.warniors
{
    class Soldiers : Characteristics, IShootable, IMovable
        {
            public void Move()
            {
                Console.WriteLine("Soldiers moving");
            }
            public void Shoot()
            {
                throw new NotImplementedException();
            }
}
