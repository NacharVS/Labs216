using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game.Civilians
{
    class Fisherman
    {
        public void SkillsFisherman(string ToFish, Random FishPerDay)
        {
            ToFish = "Рыбак ловит от 5 до 20 рыб в день";
            FishPerDay = new Random();
            int fish = FishPerDay.Next(5, 10);
          
        }         
    }
}
rf