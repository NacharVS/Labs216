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
            Archer archer1 = new Archer(100, 10, 100, 100, 100, 100);
            IMovable move = archer1;
            move.Move();
            IShootable shoot = archer1;
            shoot.Shoot();
            IAttack attack = archer1;
            attack.Attack();
            IBlind blind = archer1;
            blind.Blind();
            IFight fight = archer1;
            fight.Fight();

            HeartBreaker heartBreaker = new HeartBreaker(100, 8, 100, 60, 100, 100);
            IMovable move1 = heartBreaker;
            move1.Move();
            IShootable shoot1 = heartBreaker;
            shoot1.Shoot();
            IAttack attack1 = heartBreaker;
            attack1.Attack();
            IBlind blind1 = heartBreaker;
            blind1.Blind();

            LaraCroft lara = new LaraCroft(100, 100, 10, 99, 30, 89, 100, 100);
            IMovable move2 = lara;
            move2.Move();
            IShootable shoot2 = lara;
            shoot2.Shoot();
            IAttack attack2 = lara;
            attack2.Attack();
            IFight fight2 = lara;
            fight2.Fight();

            Luckyguy lucky = new Luckyguy(100, 10, 100, 100, 100, 100, 100, 100, 100);
            IMovable move3 = lucky;
            move3.Move();
            IShootable shoot3 = lucky;
            shoot3.Shoot();
            IAttack attack3 = lucky;
            attack3.Attack();
            IBlind blind3 = lucky;
            blind3.Blind();
            IFight fight3 = lucky;
            fight3.Fight();
            IJump jump3 = lucky;
            jump3.Jump();

            Mario mario1 = new Mario(100, 10, 100, 100, 100, 100);
            IMovable move4 = mario1;
            move4.Move();
            IShootable shoot4 = mario1;
            shoot4.Shoot();
            IAttack attack4 = mario1;
            attack4.Attack();
            IJump jump4 = mario1;
            jump4.Jump();
        }

    }
}
