using Labs216.MirasovEG.Strategy.Units.Buildings;

namespace Labs216.MirasovEG.Strategy
{
    interface IMovable
    {
        public void Move();
    }
    interface IAttack
    {
        public void MeleeAttack();
    }
    interface IShoot
    {
        public void Shoot();
    }

    interface IWork
    {
        public void Work(WareHouse wareHouse);
    }

    interface IBuild
    {
        public void Build();
    }
    interface IProfit
    {
        public void Profit(WareHouse wareHouse);
    }

    interface IHeal
    {
        public void Heal();
    }


}
