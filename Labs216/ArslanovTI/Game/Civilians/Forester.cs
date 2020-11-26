using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game.Civilians
{
    class Forester
    {
        public void SkillsForester(string Th, Random FishPerDay)
        {
            ToFish = "Рыбак ловит от 5 до 20 рыб в день";
            FishPerDay = new Random();
            int fish = FishPerDay.Next(5, 10);

        }
    }
}
