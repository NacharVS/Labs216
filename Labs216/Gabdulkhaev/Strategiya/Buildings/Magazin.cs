using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev.Strategiya.Buildings
{
    class Magazin:IRabotable
    {
        public void Rabota()
        {
            Console.WriteLine("Магазин"); // ну получается шахтер приносит деньги с шахты, медик платно лечит, кузнец платно чинит, бойцы грабят, деньги есть, фермер не нужен
            // по идее бойцы могут тупо ограбить магазин, но нет
            Console.WriteLine("Еда(1)");
            Console.WriteLine("Не еда(2)");
            int VIbor = Convert.ToInt32(Console.ReadLine());
            switch (VIbor)
            {
                case 1:
                    Console.WriteLine("Вы выбрали раздел с едой");
                    Console.WriteLine("Выберите еду");
                    Console.WriteLine("Еда1 под номером1");
                    Console.WriteLine("Еда2 под номером2");
                    Console.WriteLine("Еда3 под номером3");
                    Console.WriteLine("Еда4 под номером4");
                    Console.WriteLine("Еда5 под номером5");
                    int eda = Convert.ToInt32(Console.ReadLine());
                    switch (eda)
                    {
                        case 1:
                            Console.WriteLine("Сколько?");
                            break;
                        case 2:
                            Console.WriteLine("Сколько?");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали не еду");
                    break;
            }
            double biudget = 0; // надо бюджет сделать какой-то
        }
    }
}
