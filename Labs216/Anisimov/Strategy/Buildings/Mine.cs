using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov.Strategy.Buildings
{
    sealed class Mine : IInteractive, IResourseSourse
    {
        public int Amount { get; set; }

        public Mine(int amount)
        {
            Amount = amount;
        }
        public void Interact()
        {
            Console.WriteLine($"You see a mine.\nResurse: {Amount}");
        }
    }
}
