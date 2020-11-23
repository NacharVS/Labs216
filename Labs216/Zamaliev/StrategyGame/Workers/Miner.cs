using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zamaliev.StrategyGame.Workers
{
    public sealed class Miner : Characteristic, IMovable, IAttack
    {
        public int Speed { get; private set; }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            Console.WriteLine("qqqqqqqq");
        }
        public void qqq()
        {

        }
    }
}
