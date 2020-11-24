using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Garipova.warniors
{
    class security : Characteristics, IShootable, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Security moving");
        }
        public void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
