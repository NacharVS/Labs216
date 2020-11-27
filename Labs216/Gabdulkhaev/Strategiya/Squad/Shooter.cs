using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev.Strategiya.Boets
{
    class Shooter:Character,IStrelyatable,IHoditable 
    {
        public void Hodit()
        {
            Console.WriteLine("Shooter moving");
        }
            public void Shoot()
        {
                Random rnd = new Random();
                int luck = rnd.Next(10, 30);
            int luck2 = rnd.Next(1, 3);
            if (luck2==1)
            {
                Console.WriteLine($"Шутер попал с уроном в {luck} хп");
            }
            else if (luck2==2)
                        {
                Console.WriteLine($"Шутер не попал, но мог бы нанести {luck} урона");
            }
        }
        }
    }
