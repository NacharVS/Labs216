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
            Console.WriteLine("Инструменты(2)");
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
                            Console.WriteLine("Сколько еды?");
                            break;
                        case 2:
                            Console.WriteLine("Сколько еды?");
                            break;
                        case 3:
                            Console.WriteLine("Сколько еды?");
                            break;
                        case 4:
                            Console.WriteLine("Сколько еды?");
                            break;
                        case 5:
                            Console.WriteLine("Сколько еды?");
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали инструменты");
                    Console.WriteLine("Медикаменты для медика,кирка для шахтера или инструменты для кузнеца");
                    int vib = Convert.ToInt32(Console.ReadLine());
                    switch (vib)
                    {
                        case 1:
                            Console.WriteLine("Вы выбрали медикаменты для медика");
                            break;
                        case 2:
                            Console.WriteLine("Вы выбрали кирку для шахтера");
                            break;
                        case 3:
                            Console.WriteLine("Вы выбрали инструменты для кузнеца");
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    break;
            }
            double biudget = 0; // надо бюджет сделать какой-то
        }
    }
}
