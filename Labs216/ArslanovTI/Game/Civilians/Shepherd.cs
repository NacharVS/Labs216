using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game.Civilians
{
    class Shepherd
    {
        public void SkillsShepherd(string ToSheph, Random CowPerDay)
        {

            ToSheph = "Пастух разводит от 5 до 20 живности в день";
            CowPerDay = new Random();
            int fish = CowPerDay.Next(5, 20);

        }
    }
}
