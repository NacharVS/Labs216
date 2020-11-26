using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game.Civilians
{
    class Fisherman : IMoveable 
    {
        public int minSpeed => 4;

        public int maxSpeed =>7;

        public void Move()
        {
           Console.WriteLine("Иду на рыбалку");
        }

        public void SkillsFisherman(string ToFish, Random FishPerDay)
        {
            ToFish = "Рыбак ловит от 5 до 20 рыб в день";
            FishPerDay = new Random();
            int fish = FishPerDay.Next(5, 10);
          
        }         
    }
}
