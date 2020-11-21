using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev.Стратгия
{
    public interface Personazh
    {
        string name { get; set; }
        double age { get; set; }
        bool gender { get; set; } // human(true) or woman(fALSE)
        double health_point { get; set; }
        double damag { get; set; }
        int bronya { get; set; }
        double protection { get; set; }
        double speed { get; set; }
    }
    class skaks:Personazh
    {

        public string name
        {
            get
            {
                name = Console.ReadLine();
            }
        }
        public double age
        {
            set
            {
                int sozdanie = DateTime.Now.Millisecond;
                int tekuch = Convert.ToInt32(DateTime.Now - sozdanie);
                age = tekuch;
            }
        }
        public bool gender { get; set; }
        public double health_point
        {
            set
            {
                double health_point = 100;
            }
        }
        public double damag
        {
            set
            {
                double svoi = 10;
                Random rnd = new Random();
                double luck = rnd.Next(0, 20);
                double damag = svoi + luck*speed;
            }
        }
    }
    public double protection
    {
        set
        {
            int vibor = Console.ReadLine();
            switch (vibor)
            {
                case 1:
                    Console.WriteLine("Легкая броня");
                    protection = 50;
                    break;
                case 2:
                    Console.WriteLine("Средняя броня");
                    protection = 100;
                    break;
                case 3:
                    Console.WriteLine("Тяжелая броня");
                    protection = 150;
                    break;
            }
        }
    }
    public double speed
    {
        set
        {
            Random rnd = new Random();
            int randomspeed = rnd.Next(1, 3);
            switch (randomspeed)
            {
                case 1:
                    Console.WriteLine("Не повезло");
                    speed = 0.5;
                    break;
                case 2:
                    Console.WriteLine("+-");
                    speed = 1;
                    break;
                case 3:
                    Console.WriteLine("оп");
                    speed=1.5;
                    break;
            }
        }
    }
    public void Attack()
    {
        throw new NotImplementedException();
    }
}
