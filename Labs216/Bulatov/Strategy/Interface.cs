using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Strategy
{
    class Interface
    {
        interface IMovable
        {
            public const int minSpeed = 0;     // минимальная скорость
            private static int maxSpeed = 60;   // максимальная скорость
                                                // находим время, за которое надо пройти расстояние distance со скоростью speed
            static double GetTime(double distance, double speed) => distance / speed;
            static int MaxSpeed
            {
                get { return maxSpeed; }
                set
                {
                    if (value > 0) maxSpeed = value;
                }
            }
        }
        public class Programdsf
        {
            static void Zapusk()
            {
                Console.WriteLine(IMovable.MaxSpeed);
                IMovable.MaxSpeed = 65;
                Console.WriteLine(IMovable.MaxSpeed);
                double time = IMovable.GetTime(100, 10);
                Console.WriteLine(time);
            }
        }
    }
}
