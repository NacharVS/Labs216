using System;
using System.Collections.Generic;
using System.Text;
using Labs216.MirasovEG.Strategy.Units;

namespace Labs216.MirasovEG.Strategy
{
    class Start
    {
        delegate void Choice(string mes);
        private event Choice message;
        public void StartStrategy()
        {
            message += Message;
            message?.Invoke("Select the type of civilians \n 1 - Farmer \n 2 - Miner \n 3 - Builder \n 4 - Woodman \n 5 - Healer");
            int choiceCivil = int.Parse(Console.ReadLine());
            switch (choiceCivil)
            {
                case 1:
                    ICivilian farmer = new Farmer(100,10,1,1);
                    farmer.Move();
                    farmer.Work();
                    break;
                case 2:
                    ICivilian miner = new Miner(100, 15, 3, 1);
                    miner.Move();
                    miner.Work();
                    break;
                case 3:
                    ICivilian builder = new Builder(100, 10, 1, 2);
                    builder.Move();
                    builder.Work();
                    break;
                case 4:
                    ICivilian woodman = new Woodman(100, 10, 5, 1);
                    woodman.Move();
                    woodman.Work();
                    break;
                case 5:
                    ICivilian healer = new Healer(100, 5, 1, 1);
                    healer.Move();
                    healer.Work();
                    break;
            }
            Console.WriteLine();

            message?.Invoke("Select the type of wariors \n 1 - Infantryman \n 2 - Archer \n 3 - Cavalry \n 4 - Сatapult \n 5 - Paladin");
            int choiceWarior = int.Parse(Console.ReadLine());
            switch (choiceWarior)
            {
                case 1:
                    IMeleeWarior infantryman = new Infantryman(100, 25, 10, 5);
                    infantryman.Move();
                    infantryman.MeleeAttack();
                    break;
                case 2:
                    IDistanceWarior archer = new Archer(100, 15, 15, 5, 100);
                    archer.Move();
                    archer.Shoot();
                    break;
                case 3:
                    IMeleeWarior cavalry = new Cavalry(100, 40, 20, 15);
                    cavalry.Move();
                    cavalry.MeleeAttack();
                    break;
                case 4:
                    IDistanceWarior catapult = new Сatapult(100,45,25,3,150);
                    catapult.Move();
                    catapult.Shoot();
                    break;
                case 5:
                    IMultiWarior paladin = new Paladin(100, 50, 30, 10, 75);
                    paladin.Move();
                    paladin.MeleeAttack();
                    paladin.Shoot();
                    break;
            }
            Console.WriteLine();

            message?.Invoke("Select the type of wariors \n 1 - Farm \n 2 - Sawmill \n 3 - Mine \n 4 - Townhall \n 5 - Tower");
            int choiceBuild = int.Parse(Console.ReadLine());
            switch (choiceBuild)
            {
                case 1:
                    IBuilding farm = new Farm(500, 100);
                    farm.Profit();
                    break;
                case 2:
                    IBuilding sawmill = new Sawmill(500, 100);
                    sawmill.Profit();
                    break;
                case 3:
                    IBuilding mine = new Mine(700, 150);
                    mine.Profit();
                    break;
                case 4:
                    IBuilding townhall = new Townhall(1000, 200);
                    townhall.Profit();
                    break;
                case 5:
                    IWarBuilding tower = new Tower(1000, 150, 30, 100);
                    tower.Shoot();
                    break;
            }
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
