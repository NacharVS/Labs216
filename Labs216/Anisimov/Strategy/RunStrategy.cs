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
            Console.WriteLine("Civilian");
            Console.WriteLine();

            Console.WriteLine("Farmer");
            Console.WriteLine();
            IMovable movefarmer = new Farmer(100, 100, 100);
            movefarmer.Move();
            IWorkable farmer = new Farmer(100, 100, 100);
            farmer.Work();
            Console.WriteLine();

            Console.WriteLine("CivBoat");
            Console.WriteLine();
            IMovable moveCivBoat = new CivBoat(100, 100, 100);
            moveCivBoat.Move();
            IWorkable CivBoat = new Farmer(100, 100, 100);
            CivBoat.Work();
            Console.WriteLine();

            Console.WriteLine("CivHelicopter");
            Console.WriteLine();
            IMovable moveCivHelicopter = new CivHelicopter(100, 100, 100);
            moveCivHelicopter.Move();
            IWorkable CivHelicopter = new CivHelicopter(100, 100, 100);
            CivHelicopter.Work();
            Console.WriteLine();

            Console.WriteLine("Doctor");
            Console.WriteLine();
            IMovable moveDoctor = new Doctor(100, 100, 100);
            moveDoctor.Move();
            IWorkable Doctor = new Doctor(100, 100, 100);
            Doctor.Work();
            Console.WriteLine();

            Console.WriteLine("Politican");
            Console.WriteLine();
            IMovable movePolitican = new Politican(100, 100, 100);
            movePolitican.Move();
            IWorkable Politican = new Politican(100, 100, 100);
            Politican.Work();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("WarUnit");
            Console.WriteLine();

            Console.WriteLine("Knight");
            Console.WriteLine();
            IMovable moveKnight = new Knight(100, 100, 100, 100);
            moveKnight.Move();
            IAttack Knight = new Knight(100, 100, 100, 100);
            Knight.Attack();
            Console.WriteLine();

            Console.WriteLine("Archer");
            Console.WriteLine();
            IMovable moveArcher = new Archer(100, 100, 100, 100, 100, 100);
            moveArcher.Move();
            IAttack Archer = new Archer(100, 100, 100, 100, 100, 100);
            Archer.Attack();
            IShootable shootArcher = new Archer(100, 100, 100, 100, 100, 100);
            shootArcher.Shoot();
            Console.WriteLine();

            Console.WriteLine("WarBoat");
            Console.WriteLine();
            IMovable moveWarBoat = new WarBoat(100, 100, 100, 100, 100, 100);
            moveWarBoat.Move();
            IAttack WarBoat = new WarBoat(100, 100, 100, 100, 100, 100);
            WarBoat.Attack();
            IShootable shootWarBoat = new WarBoat(100, 100, 100, 100, 100, 100);
            shootWarBoat.Shoot();
            Console.WriteLine();

            Console.WriteLine("WarHelicopter");
            Console.WriteLine();
            IMovable moveWarHelicopter = new WarHelicopter(100, 100, 100, 100, 100, 100);
            moveWarHelicopter.Move();
            IAttack WarHelicopter = new WarHelicopter(100, 100, 100, 100, 100, 100);
            WarHelicopter.Attack();
            IShootable shootWarHelicopter = new WarHelicopter(100, 100, 100, 100, 100, 100);
            shootWarHelicopter.Shoot();
            Console.WriteLine();

            Console.WriteLine("Spearman");
            Console.WriteLine();
            IMovable moveSpearman = new Spearman(100, 100, 100, 100);
            moveSpearman.Move();
            IAttack Spearman = new Spearman(100, 100, 100, 100);
            Spearman.Attack();
            Console.WriteLine();



        } 
    }
}
