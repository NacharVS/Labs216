using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Strategy.Buildings
{
    class Forest
    {
        public int Amount { get; set; }

        public Forest(int amount)
        {
            Amount = amount;
        }
        public void Interact()
        {
            Console.WriteLine($"You see a forest. Resurse: {Amount}");
        }
    }
}
