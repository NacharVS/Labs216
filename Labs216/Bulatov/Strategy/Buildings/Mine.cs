using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Strategy.Buildings
{
    public class Mine : IInteract, IResourseSourse
    {
        public int Amount { get; set; }

        public Mine(int amount)
        {
            Amount = amount;
        }
        public void Interact()
        {
            Console.WriteLine($"You see a mine. Resurse: {Amount}");
        }
    }
}
