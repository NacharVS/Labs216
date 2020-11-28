using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Zamaliev.StrategyGame;


namespace Labs216.Zamaliev.StrategyGame.Units
{
    class Archers : Characteristic, IMovable, IShootable
    {
        public Archers()
        {
            int health = 30;
            Health = health;
        }

        public int Speed { get; set; }

        public void Move()
        {
           Console.WriteLine("Начал идти");
        }

        public void Shoot()
        {
           Console.WriteLine("Начал стрелять");
        }
    }
}
