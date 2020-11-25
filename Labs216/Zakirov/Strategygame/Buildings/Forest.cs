using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Strategygame
{
   public class Forest : IInteractivchik, IResourseSourse
    {
        public int Amount { get; set; }

        public Forest(int amount)
        {
            Amount = amount;
        }
        public void Interact()
        {
            Console.WriteLine($"You see a forest.\nResurse: {Amount}");
        }
    }

}
