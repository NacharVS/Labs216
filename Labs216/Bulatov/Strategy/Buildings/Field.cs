using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Strategy.Buildings
{
    public class Field : IInteractivchik, IResourseSourse
    {
        public int Amount { get; set; }

        public Field(int amount)
        {
            Amount = amount;
        }
        public void Interact()
        {
            Console.WriteLine($"You see a field. Resurse: {Amount}");
        }
    }
}
