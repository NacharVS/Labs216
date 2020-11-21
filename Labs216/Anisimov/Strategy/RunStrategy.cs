using System;
using Labs216.Anisimov.Strategy.Units;

namespace Labs216.Anisimov.Strategy
{
    class RunStrategy
    {
        public static void Run()
        {
            IMovable move;
            IWorkable work;
            IAttack attack;
            IShootable shoot;
            IInteractive interactive;
            IGather Gatherer;
            IGather Source;
            IGather Vault;

            Console.WriteLine();
            Console.WriteLine("Building");
            Console.WriteLine();

            Console.WriteLine("Wall");
            Console.WriteLine();
            interactive = new Wall(100, 100);
            interactive.Interact();
            Console.WriteLine();

            Console.WriteLine("Gate");
            Console.WriteLine();
            interactive = new Gate(100, 100);
            interactive.Interact();
            Console.WriteLine();

            Console.WriteLine("Tower");
            Console.WriteLine();
            interactive = new Tower(100, 100, 100, 100);
            interactive.Interact();

            shoot = new Tower(100, 100, 100, 100);
            shoot.Shoot();
            Console.WriteLine();

            Console.WriteLine("Mine");
            Console.WriteLine();
            interactive = new Mine(100, 100, 1000);
            interactive.Interact();

            Source = new Mine(100, 100, 1000);
            Console.WriteLine();

            Console.WriteLine("GoldStorage");
            Console.WriteLine();
            interactive = new GoldStorage(100, 100);
            interactive.Interact();

            Vault = new GoldStorage(100, 100);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Civilian");
            Console.WriteLine();

            Console.WriteLine("Farmer");
            Console.WriteLine();
            move = new Farmer(100, 100, 100);
            move.Move();

            work = new Farmer(100, 100, 100);
            work.Work();
            Console.WriteLine();

            Console.WriteLine("CivBoat");
            Console.WriteLine();
            move = new CivBoat(100, 100, 100);
            move.Move();

            work = new CivBoat(100, 100, 100);
            work.Work();
            Console.WriteLine();

            Console.WriteLine("CivHelicopter");
            Console.WriteLine();
            move = new CivHelicopter(100, 100, 100);
            move.Move();

            work = new CivHelicopter(100, 100, 100);
            work.Work();
            Console.WriteLine();

            Console.WriteLine("Doctor");
            Console.WriteLine();
            move = new Doctor(100, 100, 100);
            move.Move();

            work = new Doctor(100, 100, 100);
            work.Work();
            Console.WriteLine();

            Console.WriteLine("Miner");
            Console.WriteLine();
            move = new Miner(100, 100, 100);
            move.Move();

            work = new Miner(100, 100, 100);
            work.Work();

            Gatherer = new Miner(100, 100, 100);
            Gatherer.Gather(Source);
            Gatherer.Store(Vault);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("WarUnit");
            Console.WriteLine();

            Console.WriteLine("Knight");
            Console.WriteLine();
            move = new Knight(100, 100, 100, 100);
            move.Move();

            attack = new Knight(100, 100, 100, 100);
            attack.Attack();
            Console.WriteLine();

            Console.WriteLine("Archer");
            Console.WriteLine();
            move = new Archer(100, 100, 100, 100, 100, 100);
            move.Move();

            attack = new Archer(100, 100, 100, 100, 100, 100);
            attack.Attack();

            shoot = new Archer(100, 100, 100, 100, 100, 100);
            shoot.Shoot();
            Console.WriteLine();

            Console.WriteLine("WarBoat");
            Console.WriteLine();
            move = new WarBoat(100, 100, 100, 100, 100, 100);
            move.Move();

            attack = new WarBoat(100, 100, 100, 100, 100, 100);
            attack.Attack();

            shoot = new WarBoat(100, 100, 100, 100, 100, 100);
            shoot.Shoot();
            Console.WriteLine();

            Console.WriteLine("WarHelicopter");
            Console.WriteLine();
            move = new WarHelicopter(100, 100, 100, 100, 100, 100);
            move.Move();

            attack = new WarHelicopter(100, 100, 100, 100, 100, 100);
            attack.Attack();

            shoot = new WarHelicopter(100, 100, 100, 100, 100, 100);
            shoot.Shoot();
            Console.WriteLine();

            Console.WriteLine("Spearman");
            Console.WriteLine();
            move = new Spearman(100, 100, 100, 100);
            move.Move();

            attack = new Spearman(100, 100, 100, 100);
            attack.Attack();
            Console.WriteLine();              
        } 
    }
}
