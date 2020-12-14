using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev
{
    class Bibloteka
    {
        public static void Knigi()
        {
            Queue<string> knigis = new Queue<string>();
            knigis.Enqueue("Робинзон крузо, Даниель Дефо, 2015, Школьная библиотека");
            knigis.Enqueue("Остров сокровищ, Роберт Льюис Стивенсон, 2015, Школьная библиотека");
            knigis.Enqueue("Сказки на все времена, А.С. Пушкин, 2013, Проф пресс");
            knigis.Enqueue("Веселые стихи о школе, -, 2015, Школьная Библиотека ");
            knigis.Enqueue("Зеленая миля, Стивен Кинг, 2013, АСТ");
            string a = knigis.Dequeue();
            Console.WriteLine(a);
            foreach (var item in knigis)
            {
                Console.WriteLine(item);
            }
        }
    }
}
