using Labs216.Delegates;
using Labs216.GaraevaAF;
using Labs216.Lab2;
using Labs216.Lab3;
using Labs216.Lab4;
using Labs216.Warniors;
using System;

namespace Labs216
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Archer archer1 = new Archer(100,5);
            IMovable move = archer1;
            move.Move();
            IShootable shoot = archer1;
            shoot.Shoot();

            Croissant croissant2 = new Croissant();
            IMovable move2 = croissant2;
            move2.Move();
            IShootable shoot2 = croissant2;
            shoot2.Shoot();

            FootSoldier footSoldier3 = new FootSoldier();
            IMovable move3 = footSoldier3;
            move3.Move();
            IShootable shoot3 = footSoldier3;
            shoot3.Shoot();

            Goodness goodness4 = new Goodness();
            IMovable move4 = goodness4;
            move4.Move();
            IShootable shoot4 = goodness4;
            shoot4.Shoot();

            Zubarjat zubarjat5 = new Zubarjat();
            IMovable move5 = zubarjat5;
            move5.Move();
            IShootable shoot5 = zubarjat5;
            shoot5.Shoot();

        }

    }
}
