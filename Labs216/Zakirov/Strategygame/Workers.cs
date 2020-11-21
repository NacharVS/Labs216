using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Strategygame
{
    class Workers
    {
        public class Builder : Characteristics, IMovable, ICreatable
        {          
            public void Construct()
            {
                Console.WriteLine("Builder creating");
            }

            public void Move()
            {
                Console.WriteLine("Builder moving");
            }
        }
    }
}
