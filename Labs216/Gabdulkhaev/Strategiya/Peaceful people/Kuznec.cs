using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Gabdulkhaev.Strategiya.Boets;

namespace Labs216.Gabdulkhaev.Strategiya.Peaceful_people
{
    class Kuznec: Character, IHoditable, IRabotable, INanositUronable
    {
        public void Hodit()
        {
            Console.WriteLine("Кузнец пошел в кузницу");
        }
        public void Rabota()
        {
            Miner prikol = new Miner();
            prikol.kirka_sost = prikol.kirka_sost + 10;
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
