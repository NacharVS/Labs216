using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Strategy.Buildings
{
    public class River : IInteract, IResourseSourse
    {
        public int Amount { get; set; }

        public River(int amount)
        {
            Amount = amount;
        }
        public void Interact()
        {
            Console.WriteLine($"You see a River. Resurse: {Amount}");
        }
    }
}
