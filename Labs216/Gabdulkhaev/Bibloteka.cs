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
            knigis.Enqueue("Первая книга");
            knigis.Enqueue("Вторая книга");
            knigis.Enqueue("Третья книга");
            knigis.Enqueue("Четвертая книга");
            knigis.Enqueue("Пятая книга");
            string a = knigis.Dequeue();
            Console.WriteLine(a);
            foreach (var item in knigis)
            {
                Console.WriteLine(item);
            }
        }
    }
}
