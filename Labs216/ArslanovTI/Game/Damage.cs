using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI.Game
{

    class Attack
    {
        public int _attackrange;
        public int _splashattack;
        public int _attackspeed;


       
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
    }
}

