using Labs216.Delegates;
using Labs216.GaraevaAF;
using Labs216.Lab2;
using Labs216.Lab3;
using Labs216.Lab4;
using Labs216.Warniors;
using Labs216.Workers;
using Labs216.Buildings;
using System;

namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            Archer archer1 = new Archer(100, 10, 100, 100, 100, 100);
            IArcher move = archer1;
            move.Move();
            IArcher shoot = archer1;
            shoot.Shoot();
            IArcher blind = archer1;
            blind.Blind();
            IArcher fight = archer1;
            fight.Fight();

            HeartBreaker heartBreaker1 = new HeartBreaker(100, 10, 79, 99, 100, 100);
            IHeartBreakers move2 = heartBreaker1;
            move2.Move();
            IHeartBreakers shoot2 = heartBreaker1;
            shoot2.Shoot();
            IHeartBreakers blind2 = heartBreaker1;
            blind2.Blind();

            LaraCroft laraCroft = new LaraCroft(100, 100, 10, 100, 45, 77, 100, 100);
            ILaraCroft move3 = laraCroft;
            move3.Move();
            ILaraCroft shoot3 = laraCroft;
            shoot3.Shoot();
            ILaraCroft fight3 = laraCroft;
            fight3.Fight();

            Luckyguy luckyguy1 = new Luckyguy(100, 10, 100, 100, 100, 100, 100, 100, 100);
            ILuckyguy move4 = luckyguy1;
            move4.Move();
            ILuckyguy shoot4 = luckyguy1;
            shoot4.Shoot();
            ILuckyguy blind4 = luckyguy1;
            blind4.Blind();
            ILuckyguy fight4 = luckyguy1;
            fight4.Blind();
            ILuckyguy jump4 = luckyguy1;
            jump4.Jump();

            Mario mario1 = new Mario(100, 10, 56, 87, 100, 100);
            IMario move5 = mario1;
            move5.Move();
            IMario shoot5 = mario1;
            shoot5.Shoot();
            IMario jump5 = mario1;
            jump5.Jump();

            Assistant assistant = new Assistant(100, 10, 89, 100);
            IAssistant move6 = assistant;
            move6.Move();
            IAssistant help6 = assistant;
            help6.Help();

            Cook cook1 = new Cook(100, 10, 100, 100);
            ICook move7 = cook1;
            move7.Move();
            ICook cook7 = cook1;
            cook7.Cooking();

            Medic medic = new Medic(100, 10, 100, 100);
            IMedic move8 = medic;
            move8.Move();
            IMedic examine = medic;
            examine.Examine();
            IMedic treats = medic;
            treats.Treats();
            IMedic help8 = medic;
            help8.Help();

            Teacher teacher = new Teacher(100, 10, 100, 100);
            ITeacher move9 = teacher;
            move9.Move();

            ArcherTower archerTower = new ArcherTower(100, 100);
            IForBluindings bluindings = archerTower;
            bluindings.Collab();
        }

    }
}
