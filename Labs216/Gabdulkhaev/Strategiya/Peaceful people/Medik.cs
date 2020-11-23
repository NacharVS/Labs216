using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Gabdulkhaev.Strategiya.Boets;

namespace Labs216.Gabdulkhaev.Strategiya.Peaceful_people
{
    class Medik:Character,ILechitable,IHoditable, INanositUronable
    {
        public void Lechit()
        {
            Console.WriteLine("Медик лечит бойцов");
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
