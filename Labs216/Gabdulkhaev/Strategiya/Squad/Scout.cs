using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Gabdulkhaev.Strategiya.Boets;

namespace Labs216.Gabdulkhaev.Strategiya.Squad
{
    class Scout:Character,IHoditable,IRabotable,INanositUronable
    {
        public void Hodit()
        {
            Console.WriteLine("Scout очень быстро и незаметно ходит");
        }
        public void Rabota()
        {
            Console.WriteLine("Scout идет на разведку");
        }
        public void Uron()
        {
            Random rnd = new Random();
            int scout_uron = rnd.Next(5, 20);
            Console.WriteLine($"Скаут нанес {scout_uron} единиц урона противнику");
        }
    }
}
