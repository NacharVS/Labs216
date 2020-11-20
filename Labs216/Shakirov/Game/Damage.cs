using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov.Game
{
    class Damage
    {
       interface IDamage
        {
            public void Damage(int damageArcher,int damageNinja, int damageknight, int damageWizard)
            {
                damageArcher = 45;
                damageNinja = 55;
                damageknight = 40;
                damageWizard = 90;

            }
        }
    }
}
