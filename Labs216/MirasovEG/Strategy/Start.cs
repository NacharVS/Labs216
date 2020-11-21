using System;
using Labs216.MirasovEG.Strategy.Units.Buildings;
using Labs216.MirasovEG.Strategy.Units.Civilian;
using Labs216.MirasovEG.Strategy.Units.Warior;

namespace Labs216.MirasovEG.Strategy
{
    class Start
    {
        delegate void Choice(string mes);
        private event Choice message;
        WareHouse wareHouse = new WareHouse(500,500);

        public void StartStrategy()
        {
            message += Message;
            Console.WriteLine("Farmer");
            Farmer farmer = new Farmer(100, 10, 5, 2);
            for (int i = 0; i < 3; i++)
            {
                message?.Invoke("What do you want to do: \n 1 - Work \n 2 - Move \n 3 - Attack");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        IWork farmerWork = farmer;
                        farmerWork.Work(wareHouse);
                        break;
                    case 2:
                        IMovable farmerMove = farmer;
                        farmerMove.Move();
                        break;
                    case 3:
                        IAttack farmerAttack = farmer;
                        farmerAttack.MeleeAttack();
                        break;
                }
            }

            Console.WriteLine("Paladin");
            Paladin paladin = new Paladin(100, 10, 5, 2, 50);
            for (int i = 0; i < 4; i++)
            {
                message?.Invoke("What do you want to do: \n 1 - Move \n 2 - Shoot \n 3 - Attack \n 4 - Heal");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        IMovable paladinMove = paladin;
                        paladinMove.Move();
                        break;
                    case 2:
                        IShoot paladinShoot = paladin;
                        paladinShoot.Shoot();
                        break;
                    case 3:
                        IAttack paladinAttack = paladin;
                        paladinAttack.MeleeAttack();
                        break;
                    case 4:
                        IHeal paladinHeal = paladin;
                        paladinHeal.Heal();
                        break;

                }
            }

            Console.WriteLine();

            Console.WriteLine("Townhall");
            Townhall townhall = new Townhall(1000, 500);
            IProfit townhallProfit = townhall;
            townhallProfit.Profit(wareHouse);
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
