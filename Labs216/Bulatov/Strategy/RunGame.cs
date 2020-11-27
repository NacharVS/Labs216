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
            IInteract interactive;

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

            var field = new Field(50);

            interactive = field;
            interactive.Interact();

            var forest = new Forest(50);

            interactive = forest;
            interactive.Interact();

            var mine = new Mine(50);

            interactive = mine;
            interactive.Interact();

            var river = new River(0);

            interactive = river;
            interactive.Interact();

            var tower = new Tower(6, 6);

            interactive = tower;
            interactive.Interact();

            var storage = new TownHall(7, 1000);

            interactive = storage;
            interactive.Interact();

            Console.WriteLine();
            Console.WriteLine("Workers");
            Console.WriteLine();

            var farmer = new Farmer(8, 8);

            move = farmer;
            move.Move();

            gatherer = farmer;
            gatherer.Gather(field);
            gatherer.Store(storage);

            interactive.Interact();

            var fisherman = new Fisherman(10, 10);

            move = fisherman;
            gatherer.Gather(river);
            gatherer.Store(storage);
            move.Move();

            var lumberjack = new lumberjack(11, 11);

            move = lumberjack;
            move.Move();

            gatherer = lumberjack;
            gatherer.Gather(forest);
            
            gatherer.Store(storage);

            interactive.Interact();

            var merchant = new Merchant(12, 12);

            move = merchant;
            move.Move();

            var miner = new Miner(13, 13);

            move = miner;
            move.Move();

            gatherer = miner;
            gatherer.Gather(mine);
            
            gatherer.Store(storage);            

            interactive.Interact();
        }
    }
}
