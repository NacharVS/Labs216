using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Tarskih.Interfaces;
using Labs216.Tarskih.Abstract_Classes;
using Labs216.Tarskih.Entity;
using Labs216.Tarskih.Constructions;

namespace Labs216.Tarskih
{
    class Start
    {
        delegate void Choice(string mes);
        private event Choice message;

        public void StartStrategy()
        {
            message += Message;
            Console.WriteLine("Healer");
            Healer healer = new Healer(0, 0, 100, 10, 30, 5);
            for (int i = 0; i < 3; i++)
            {
                message?.Invoke("What do you want to do: \n 1 - Heal \n 2 - Move \n 3 - Attack");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        IHeal healerWork = healer;
                        healerWork.Heal();
                        break;
                    case 2:
                        IMove healerMove = healer;
                        healerMove.Move();
                        break;
                    case 3:
                        IAttack healerAttack = healer;
                        healerAttack.Attack();
                        break;
                }
            }

            Console.WriteLine("Guardian");
            Guardian guardian = new Guardian(0, 0, 100, 25, 5, 50);
            for (int i = 0; i < 2; i++)
            {
                message?.Invoke("What do you want to do: \n 1 - Move \n 2 - Attack");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        IMove guardianMove = guardian;
                        guardianMove.Move();
                        break;
                    case 2:
                        IAttack guardianAttack = guardian;
                        guardianAttack.Attack();
                        break;
                }
            }

            Console.WriteLine();

            Console.WriteLine("WarTower");
            WarTower wartower = new WarTower(0, 0, 1000, 30, 5);
            for (int i = 0; i < 2; i++)
            {
                message?.Invoke("What do you want to do: \n 1 - Attack \n 2 - Shoot \n 3 - Place");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        IAttack wartowerAttack = wartower;
                        wartowerAttack.Attack();
                        break;
                    case 2:
                        IShoot wartowerShoot = wartower;
                        wartowerShoot.Shoot();
                        break;
                    case 3:
                        IPlace wartowerPlace = wartower;
                        wartowerPlace.Place();
                        break;
                }
            }
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
