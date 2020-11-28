using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Strategygame.Buildings
{
   public  class Lake : Characteristics, IInteractivchik
    {
        public int Amount { get; set; }

        public Lake(int amount)
        {
            Amount = amount;
        }
        public void Interact()
        {
            Console.WriteLine($"You see a River. Resurse: {Amount}");
        }
    }
}
