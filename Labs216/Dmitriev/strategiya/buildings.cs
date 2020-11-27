using System;
using static Labs216.Dmitriev.strategiya.Infa;

namespace Labs216.Dmitriev.strategiya
{
    internal class infa4elovek
    {
        sealed class stena : infaBuilding
        {
            public int Distance { get; private set; }
            public int ShootDamage { get; private set; }

            public stena(int zdorove, int oborona)
            {
                _Zdorove = zdorove;
                _Oborona = oborona;
            }
        }
        public void Interact()
        {
            Console.WriteLine("ПРОХОЖДЕНИЕ ПРЕПЯТСТВИЯ" );
        }
    }


        sealed class bshnya :  infaBuilding
    {
            public int Distance { get; private set; }
            public int ShootDamage { get; private set; }

               public bshnya(int Zdorove, int Oborona, )
               {
                   _Zdorove = Zdorove;
                   _Oborona = Oborona;
               }
        }
        public void Interact()
        {
            Console.WriteLine("ПЕРЕМЕЩЕНИЕ ПО БАШНЕ ИЛИ ЖЕ В БАШНЕ ");
        }
    
}




