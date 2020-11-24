using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Warniors
{
    class Croissant: Characteristics, IMovable, IShootable
    {
        public void Move()
        {
            Console.WriteLine("Croissant moving");
        }
        public void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
