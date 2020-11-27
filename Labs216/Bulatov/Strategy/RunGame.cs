using Labs216.Bulatov.Strategy.Army;
using Labs216.Bulatov.Strategy.Buildings;
using Labs216.Bulatov.Strategy.Workers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Bulatov.Strategy
{
    public class RunGame 
    { 
        public static void Run()         
        {
            IMovable move;
            IAttack attack;
            IShootable shoot;
            IGather gatherer;
            IInteract inter;

            Console.WriteLine();
            Console.WriteLine("Army");
            Console.WriteLine();

            var archer = new Archer(1, 1, 1);

            move = archer;
            move.Move();

            shoot = archer;
            shoot.Shoot();

            var catapult = new Catapult(2, 2, 2);

            move = catapult;
            move.Move();

            shoot = catapult;
            shoot.Shoot();

            var cavalry = new Cavalry(3, 3, 3);

            move = cavalry;
            move.Move();

            attack = cavalry;
            attack.Attack();

            var knight = new Knight(4, 4, 4);

            move = knight;
            move.Move();

            attack = knight;
            attack.Attack();

            var swordsMan = new SwordsMan(5, 5, 5);

            move = swordsMan;
            move.Move();

            Console.WriteLine();
            Console.WriteLine("Buildings");
            Console.WriteLine();

            var field = new Field(5);

            inter = field;
            inter.Interact();

            var forest = new Forest(5);

            inter = forest;
            inter.Interact();

            var mine = new Mine(5);

            inter = mine;
            inter.Interact();

            var river = new River(5);

            inter = river;
            inter.Interact();

            var tower = new Tower(6, 6);

            inter = tower;
            inter.Interact();

            var storage = new TownHall(7, 7);

            inter = storage;
            inter.Interact();

            Console.WriteLine();
            Console.WriteLine("Workers");
            Console.WriteLine();

            var farmer = new Farmer(12, 12);

            move = farmer;
            move.Move();

            gatherer = farmer;
            gatherer.Gather(field);
            gatherer.Store(storage);

            inter.Interact();

            var fisherman = new Fisherman(10, 10);

            move = fisherman;
            move.Move();

            var lumberjack = new lumberjack(13, 13, 13);

            move = lumberjack;
            move.Move();

            gatherer = lumberjack;
            gatherer.Gather(forest);
            gatherer.Gather(forest);
            gatherer.Store(storage);

            inter.Interact();
        }
    }
}
