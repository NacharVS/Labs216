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
            Miner chaxter = new Miner();
            Kuznec kuznecccc= new Kuznec();
            if (chaxter.nakopal > 0 && kuznecccc.kuznecskie_prikoli > 0)
            {
                Console.WriteLine("Строитель может строить");
            }
            else if (chaxter.nakopal<=0 || kuznecccc.kuznecskie_prikoli<=0)
                {
                Console.WriteLine("Недостаточно инструментов или ресурсов");
            }
        }
        public void Uron()
        {
            Random rnd = new Random();
            int uron_stroi = rnd.Next(-3, 3);
            if (uron_stroi>0)
            {
                Console.WriteLine($"Строитель нанес {uron_stroi} урона противнику");
            }
            else if (uron_stroi<0)
            {
                Console.WriteLine($"Строитель слишком слаб, он нанес {uron_stroi} хп урона себе, качайте его или покупайте ему что-нибудь в магазине ");
            }
        }
    }
}
