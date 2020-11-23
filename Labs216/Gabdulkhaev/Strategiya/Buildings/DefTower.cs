using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev.Strategiya.Buildings
{
    class DefTower:Character,IStrelyatable
    {
        public void Shoot()
        {
            Random rndd = new Random();
            int deffend = rndd.Next(1, 3);
            if (deffend==1)
            {
                Console.WriteLine("Башня обнаружила противника");
            }
            else if (deffend==2)
                        {
                Console.WriteLine("Никого не найдено");
            }
        }
    }
}
