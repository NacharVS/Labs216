using System;

namespace Labs216.Dmitriev.strategiya
{
    internal class infa4elovek
    {
        sealed class stena : infa
        {
            public int Distance { get; private set; }
            public int ShootDamage { get; private set; }

            public stena(int zdorove, int oborona, )
            {
                Zdorove = zdorove;
                Oborona = oborona;
            }
        }
        public void Interact()
        {
            Console.WriteLine("ПРОХОЖДЕНИЕ ПРЕПЯТСТВИЯ" );
        }
    }


        sealed class bshnya : infa
           {
            public int Distance { get; private set; }
            public int ShootDamage { get; private set; }

               public bshnya(int Zdorove, int Oborona, )
               {
                   zdorove = Zdorove;
                   oborona = Oborona;
               }
           }
        public void Interact()
        {
            Console.WriteLine("ПЕРЕМЕЩЕНИЕ ПО БАШНЕ ИЛИ ЖЕ В БАШНЕ ");
        }
    
}




