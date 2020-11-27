using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Gabdulkhaev.Strategiya.Boets;

namespace Labs216.Gabdulkhaev.Strategiya.Peaceful_people
{
    class Shoot:Character,IHoditable,IRabotable,INanositUronable // шут, который не стрелять, а шут который шут
    {
        public void Hodit()
        {
            Console.WriteLine("Shoot идет на работу");
        }
        public void Rabota()
        {
            Console.WriteLine("Шут шутит");
        }
        public void Uron()
        {
            Random rnd = new Random();
            int shootka_ponravilas_na_rnd_urona = rnd.Next(-10, 0);
            Console.WriteLine($"Шутка понравилась зрителям на {shootka_ponravilas_na_rnd_urona} единиц урона, пополнять хп шут может у медика");
        }

    }
}
