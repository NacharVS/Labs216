﻿using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Gabdulkhaev.Strategiya.Boets;

namespace Labs216.Gabdulkhaev.Strategiya.Peaceful_people
{
    class Medik:Character,IHoditable, INanositUronable, IRabotable
    {
        public void Rabota()
        {
            int medicinskie_prikoli = 1000; // медикаменты
            Random rnd = new Random();
            int medik_Lech = rnd.Next(1, 3); // может вылечит, а может не знает как лечить
            Random rnd1 = new Random();
            int medik_lech1 = rnd.Next(1, 10); // вылечит на несколько хп (до 10)
            if (medik_Lech == 1&&medicinskie_prikoli>0)
            {
                Console.WriteLine($"Медик вылечил бойца на +{medik_lech1} hp");
            }
            else if (medik_Lech == 2 ||medicinskie_prikoli<=0)
            {
                Console.WriteLine("Медик не знает как лечить или у него нет медикаментов");
            }
        }
        public void Hodit()
        {
            Console.WriteLine("Медик ходит"); // нет летает
        }
        public void Uron()
        {
            Random rnd = new Random();
            int medik_uron = rnd.Next(0, 1);
            Console.WriteLine($"Медик нанес {medik_uron} хелф-поинт урона"); // ну должен лечить, но еще умеет наносить урон
        }
    }
}
