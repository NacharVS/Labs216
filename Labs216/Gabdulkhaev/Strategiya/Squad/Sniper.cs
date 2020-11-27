using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev.Strategiya.Squad
{
    class Sniper:Character,IStrelyatable // не ходит, сидит на месте и стреляет с большим кол-во урона
    {
        public void Shoot()
        {
            Random rnd = new Random();
            int uron_sniper = rnd.Next(50, 80);
            Random rnd1 = new Random();
            int popal_ne_popal = rnd.Next(0, 10);
            if (popal_ne_popal == 8)
            {
                Console.WriteLine("Снайпер промазал");
            }
            else
            {
                Console.WriteLine($"Снайпер попал и нанес {uron_sniper} урона");
            }
        }
    }
}
