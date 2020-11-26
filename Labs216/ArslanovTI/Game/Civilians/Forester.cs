using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game.Civilians
{
    class Forester 
    {
        public void SkillsForester(string ToTree, Random TreePerDay)
        {
            ToTree = "Лесник рубит от 5 до 20 деревьев в день";
            TreePerDay = new Random();
            int fish = TreePerDay.Next(5, 20);

        }
    }
}
