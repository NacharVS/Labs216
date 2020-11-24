using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game
{

    interface IDamage
    {
        


       
        public int AttackRange
        {
            get

            {
                return _attackrange;


            }
            set
            {
                _attackrange = value;
            }
        }



        public int splashAttack
        {
            get

            {
                return _splashattack;


            }
            set
            {
                _attackrange = value;
            }
        }


        public int speedAttack
        {
            get

            {
                return _attackspeed;


            }
            set
            {
                _attackspeed = value;
            }
        }

        int _attackrange { get; set; }
        int _splashattack { get; set; }
        int _attackspeed { get; set; }
    }
}

