using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Gabdulkhaev.Strategiya.Boets;

namespace Labs216.Gabdulkhaev.Strategiya.Squad
{
    class BigHPslowSpeed:Character,IHoditable,INanositUronable
    {
        public void Hodit()
        {
            Console.WriteLine("BS очень медленно ходит");
        }
        public void Uron()
        {
            Random rnd = new Random();
            int bs_uron = rnd.Next(60, 100);
            Console.WriteLine($"BS нанес {bs_uron} единиц урона");
        }
    }
}
