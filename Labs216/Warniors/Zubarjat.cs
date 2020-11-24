using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Warniors
{
    class Zubarjat: Characteristics, IShootable, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Zubarjat moving");
        }
        public void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
