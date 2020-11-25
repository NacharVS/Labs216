using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Gabdulkhaev.Strategiya.Boets;

namespace Labs216.Gabdulkhaev.Strategiya.Peaceful_people
{
    class Stroitel:IHoditable,IRabotable,INanositUronable // по идее строитель строит, если у майнера есть ресурсы, у кузнеца есть инструменты, а медик просто медик
    {
        public void Hodit()
        {
            Console.WriteLine("Строитель идет на стройку");
        }
        public void Rabota()
        {
            Miner prikol = new Miner();
            Kuznec neprikol = new Kuznec();
            if (prikol.nakopal>0)
            {

            }
        }
    }
}
