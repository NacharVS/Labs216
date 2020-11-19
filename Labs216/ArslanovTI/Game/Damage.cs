using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game
{
    class Damage
    {
        interface IDamage
        {
            static void Damage(int damageArcher, int damageWizard, int damageBerserk,  int damageknight)
            {
                damageArcher = 45;
                damageWizard = 70;
                damageBerserk = 59;
                damageknight = 67;
            }
        }
    }
}
