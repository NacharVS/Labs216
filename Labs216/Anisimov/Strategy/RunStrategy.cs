using System;
using Labs216.Anisimov.Strategy.Buildings;
using Labs216.Anisimov.Strategy.Civilian;
using Labs216.Anisimov.Strategy.Fighters;

namespace Labs216.Anisimov.Strategy
{
    class RunStrategy
    {
        public static void Run()
        {
            IMovable move;
            IAttack attack;
            IShootable shoot;
            IInteractive interactive;
            IGather gatherer;

            Console.WriteLine();
            Console.WriteLine("WarUnit");
            Console.WriteLine();

            var archer = new Archer(1, 1, 1, 1, 1, 1);

            move = archer;
            move.Move();

            attack = archer;
            attack.Attack();

            shoot = archer;
            shoot.Shoot();

            var ballista = new Ballista(2, 2, 2, 2, 2);

            move = ballista;
            move.Move();

            shoot = ballista;
            shoot.Shoot();

            var knight = new Knight(3, 3, 3, 3);

            move = knight;
            move.Move();

            attack = knight;
            attack.Attack();

            var spearman = new Spearman(4, 4, 4, 4);

            move = spearman;
            move.Move();

            attack = spearman;
            attack.Attack();

            var warBoat = new WarBoat(5, 5, 5, 5, 5);

            move = warBoat;
            move.Move();

            shoot = warBoat;
            shoot.Shoot();

            Console.WriteLine();
            Console.WriteLine("Building");
            Console.WriteLine();

            var wall = new Wall(6, 6);

            interactive = wall;
            interactive.Interact();

            var gate = new Gate(7, 7);

            interactive = gate;
            interactive.Interact();

            var tower = new Tower(8, 8, 8, 8);

            interactive = tower;
            interactive.Interact();

            shoot = tower;
            shoot.Shoot();
            tower.Interact(archer);
            shoot.Shoot();

            var forest = new Forest(5);

            interactive = forest;
            interactive.Interact();

            var mine = new Mine(5);

            interactive = mine;
            interactive.Interact();

            var field = new Field(5);

            interactive = field;
            interactive.Interact();

            var storage = new Storage(9, 9, 4);

            interactive = storage;
            interactive.Interact();

            Console.WriteLine();
            Console.WriteLine("Civilian");
            Console.WriteLine();

            var boat = new Boat(10, 10, 10);

            move = boat;
            move.Move();

            var civilian = new Civ(11, 11, 11);

            move = civilian;
            move.Move();

            var farmer = new Farmer(12, 12, 12);

            move = farmer;
            move.Move();

            gatherer = farmer;
            gatherer.Gather(field);
            gatherer.Store(storage);

            interactive.Interact();

            var lumberjack = new Lumberjack(13, 13, 13);

            move = lumberjack;
            move.Move();

            gatherer = lumberjack;
            gatherer.Gather(forest);
            gatherer.Gather(forest);
            gatherer.Store(storage);

            interactive.Interact();

            var miner = new Miner(14, 14, 14);

            move = miner;
            move.Move();

            gatherer = miner;
            for (int i = 0; i < 6; i++)
            {
                gatherer.Gather(mine);
            }
            gatherer.Store(storage);
            gatherer.Store(storage);

            interactive.Interact();
        } 
    }
}
