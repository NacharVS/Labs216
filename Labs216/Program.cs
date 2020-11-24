using Labs216.Garipova;
using Labs216.Garipova.warniors;

namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            Archer archer1 = new Archer();
            IMovable move = archer1;
            move.Move();
            IShootable shoot = archer1;
            shoot.Shoot();

            FootSoldier footSoldier = new FootSoldier();
            IMovable move2 = footSoldier;
            move2.Move();
            IShootable shoot = footSoldier;



        }
    }
}
