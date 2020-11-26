using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game.Civilians
{
    class Miner

    {
        public void SkillsMiner(string ToMine, Random DiamondPerDay)
        {
            ToMine = "Майнер добывает от 5 до 20 алмазов в день";
            DiamondPerDay = new Random();
            int fish = DiamondPerDay.Next(5, 20);

        }
    }
}
