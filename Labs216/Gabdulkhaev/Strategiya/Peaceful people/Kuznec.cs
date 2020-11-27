using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Gabdulkhaev.Strategiya.Boets;

namespace Labs216.Gabdulkhaev.Strategiya.Peaceful_people
{
    class Kuznec: Character, IHoditable, IRabotable, INanositUronable
    {
        public int kuznecskie_prikoli = 1000; // инструменты и просто материалы, покупают в магазине
        public void Hodit()
        {
            Console.WriteLine("Кузнец пошел в кузницу");
        }
        public void Rabota()
        {
            Miner prikol = new Miner();
            Random rnd = new Random();
            int kuznec_pochinka = rnd.Next(1, 100);
            Random rnd1 = new Random();
            int kuznec_wans = rnd.Next(1, 3); // либо чинит, либо нет с шансом 50 на 50
            if (kuznecskie_prikoli > 0&&kuznec_wans==1)
            {
                prikol.kirka_sost = prikol.kirka_sost + kuznec_pochinka;
            }
            else if (kuznecskie_prikoli<=0&&kuznec_wans==2)
            {
                Console.WriteLine("Кузнец не смог починить или у него нет инструментов, купите их в магазине");
            }
          // кузнец будет чинить шахтеру инструменты, по +10 за раз
        }
        public void Uron()
        {
            Random rnd = new Random();
            int Uron_chaxter = rnd.Next(1,5);
            Console.WriteLine($"Кузнец нанес {Uron_chaxter} хелф-поинт урона"); 
        }
    }
}
