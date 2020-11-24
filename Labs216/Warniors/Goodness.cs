using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Warniors
{
    class Goodness: Characteristics, IMovable, IShootable
    {
        public void Move()
        {
            Console.WriteLine("Goodness moving");
        }
        public void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
