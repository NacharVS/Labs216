﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev.Strategiya.Peaceful_people
{
    class Kuznec: Character, IHoditable, IRabotable
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
    }
}
