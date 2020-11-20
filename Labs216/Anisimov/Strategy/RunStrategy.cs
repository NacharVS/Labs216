using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Anisimov.Strategy.Units;

namespace Labs216.Anisimov.Strategy
{
    class RunStrategy
    {
        public static void Run()
        {
            ICivilian farmer = new Farmer(100, 10, 50.5);
            IWarUnit knight = new Knight(100, 20, 25, 15);
            IBuilding wall = new Wall(800, 400);
            Tower tower = new Tower(200, 100, 300, 50);
            Archer archer = new Archer(100, 5, 30, 35, 200, 22);

            Console.WriteLine("Farmer");
            
            farmer.Move();
            farmer.Work();

            Console.WriteLine("Knight");

            knight.Move();
            knight.Attack();
            
            Console.WriteLine("Archer");

            archer.Move();
            archer.Attack();
            archer.Shoot();

            Console.WriteLine("Wall");

            wall.Interact();

            Console.WriteLine("Tower");

            tower.Shoot();
            tower.Interact();
        } 
    }
}
