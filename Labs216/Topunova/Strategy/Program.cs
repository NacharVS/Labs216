using System;
using System.Collections.Generic;
using System.Text;
using System.Labs216.Topunova;
using System;


namespace Labs216.Topunova.Strategy

{
    class Program
    {
        public void Main(string[] args)
        {
            Move.Move = new Move();
            Move.MoveStrategy();
        }
        public static Archer TeachArcher()
        {
            Archer archerUnit = new Archer();
            return archerUnit;
        }
    }
}