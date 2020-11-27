using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Strategygame.Buildings
{
    sealed class Forest : Characteristics , IInteractivchik, IResourseSourse 
    {
        public int Amount { get; set; }

        public Forest(int amount)
        {
            Amount = amount;
        }
        public void Interact()
        {
            Console.WriteLine($"You see a field.\nResurse: {Amount}");
        }
    }
}
