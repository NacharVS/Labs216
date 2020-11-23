using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev.Strategiya.Boets
{
    class Pehotinets : Character, IHoditable, INanositUronable
    {
        public void Hodit()
        {
            Console.WriteLine("Пехотинец ходит");
    }
        public void Uron()
        {
            Random rnd = new Random();
            int luck = rnd.Next(1,3);
            if (luck == 1)
            {
                Console.WriteLine("Пехотинец нанес урон");
            }
            else if (luck==2)
                {
                Console.WriteLine("Пехотинец не нанес урон");
            }
        }
}
}
