using Labs216.Garipova;
using Labs216.Garipova.buildings;
using Labs216.Garipova.warniors;
using Labs216.Garipova.workers;

namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            Archer archer1 = new Archer(100, 100);
            Iwariors axe = archer1;
            axe.Axe();
            Iwariors grenade = archer1;
            grenade.Grenade();
            Iwariors stun = archer1;
            stun.Stun();


            FootSoldier foots = new FootSoldier(100, 100);
            Iwariors axe2 = foots;
            axe2.Axe();
            Iwariors grenade2 = foots;
            grenade2.Grenade();
            Iwariors stun2 = foots;
            stun2.Stun();


            ninja ninj = new ninja(100, 100);
            Iwariors axe3 = ninj;
            axe3.Axe();
            Iwariors grenade3 = ninj;
            grenade3.Grenade();
            Iwariors stun3 = ninj;
            stun3.Stun();

            security securite2 = new security(100, 100);
            Iwariors axe4 = securite2;
            axe4.Axe();
            Iwariors grenade4 = securite2;
            grenade4.Grenade();
            Iwariors stun4 = securite2;
            stun4.Stun();

            Soldiers sold = new Soldiers(100, 100);
            Iwariors axe5 = sold;
            axe5.Axe();
            Iwariors grenade5 = sold;
            grenade5.Grenade();
            Iwariors stun5 = sold;
            stun5.Stun();

            Baker baker1 = new Baker(100, 10);
            Iworkers cook = baker1;
            cook.Cook();
            Iworkers move = baker1;
            move.Move();
            Iworkers sleep = baker1;
            sleep.Sleep();
            Iworkers eat = baker1;
            eat.Eat();

            Coalminder comin = new Coalminder(100, 10);
            Iworkers cook2 = comin;
            cook2.Cook();
            Iworkers move2 = comin;
            move2.Move();
            Iworkers sleep2 = comin;
            sleep2.Sleep();
            Iworkers eat2 = comin;
            eat2.Eat();


            farmer farmer1 = new farmer(100, 10);
            Iworkers cook3 = farmer1;
            cook3.Cook();
            Iworkers move3 = farmer1;
            move3.Move();
            Iworkers sleep3 = farmer1;
            sleep3.Sleep();
            Iworkers eat3 = farmer1;
            eat3.Eat();


            fisher fish = new fisher(100, 10);
            Iworkers cook4 = fish;
            cook4.Cook();
            Iworkers move4 = fish;
            move4.Move();
            Iworkers sleep4 = fish;
            sleep4.Sleep();
            Iworkers eat4 = fish;
            eat4.Eat();


            postal_worker post= new postal_worker(100, 10);
            Iworkers cook5 = post;
            cook5.Cook();
            Iworkers move5 = post;
            move5.Move();
            Iworkers sleep5 = post;
            sleep5.Sleep();
            Iworkers eat5 = post;
            eat5.Eat();


            ArcherTower arctow  = new ArcherTower(100);
            IBuildings collabaration = arctow;
            collabaration.Collabaration();
        }
    }
}
