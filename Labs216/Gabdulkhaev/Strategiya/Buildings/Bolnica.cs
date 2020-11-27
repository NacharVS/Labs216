using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev.Strategiya.Buildings
{
    class Bolnica:IRabotable
    {
        public int medicamenti = 1000;
        public void Rabota()
        {
            Console.WriteLine("Больница работает");
        }
    }
}
