using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov.Strategy.Buildings
{
    sealed class Field : IInteractive, IResourseSourse
    {
        public int Amount { get; set; }

        public Field(int amount)
        {
            Amount = amount;
        }
        public void Interact()
        {
            Console.WriteLine($"You see a field.\nResurse: {Amount}");
        }
    }
}
