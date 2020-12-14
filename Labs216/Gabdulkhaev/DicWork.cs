using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev
{
    class DicWork
    {
        public static void Prikol()
        {
            Dictionary<int, string> bblist = new Dictionary<int, string>();
            for (int i = 0; i < 15; i++)
            {
                Random rnd3 = new Random();
                int _id1 = rnd3.Next(100, 250);
                Random rnd2 = new Random();
                int _id2 = rnd2.Next(250, 500);
                Random rnd1 = new Random();
                int _id3 = rnd1.Next(500, 750);
                Random rnd0 = new Random();
                int _id4 = rnd0.Next(750, 1000);
                // сначала ген 4 числа, потом делим на 4 числа
                Random rnd5 = new Random();
                int _id5 = rnd5.Next(2, 20);
                Random rnd6 = new Random();
                int _id6 = rnd6.Next(20, 40);
                Random rnd7 = new Random();
                int _id7 = rnd7.Next(40, 60);
                Random rnd8 = new Random();
                int _id8 = rnd8.Next(60, 80);
                Random rnd9 = new Random();
                int _idconech = rnd9.Next(1, 10);
                int id = (_id1 / _id5 + _id2 / _id6 + _id3 / _id7 + _id4 / _id8) * _idconech;
                string imya = Console.ReadLine();
                bblist.Add(id, imya);
            }
            foreach (KeyValuePair<int, string> item in bblist)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
    }
}
