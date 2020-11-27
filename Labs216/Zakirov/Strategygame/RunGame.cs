
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov.Strategygame
{
    class RunGame
    {
        public static void Run()
        {
            IMovable move;
            IAttack attack;
            IShootable shoot;            
            IGather gatherer;
            IInteractivchik interactiv;
            IGather sourse;
            Console.WriteLine();
            Console.WriteLine("Building");
            Console.WriteLine();

            Console.WriteLine("Field");
            Console.WriteLine();
            interactiv = new Buildings.Forest(100);
            interactiv.Interact();
            Console.WriteLine();

            Console.WriteLine("Forest");
            Console.WriteLine();
            interactiv = new Buildings.Forest(100);
            interactiv.Interact();
            Console.WriteLine();

            Console.WriteLine("Mine");
            Console.WriteLine();
            interactiv = new Buildings.Mine(100);
            interactiv.Interact();
            Console.WriteLine();







        }

    }
}
