using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace Labs216.Topunova.Strategy
{
    class Archer : Characteristics, IShot, IMove
    {
        public Archer(int Health, int Force, int Arrow, string IMove)
        {
            Health = Health;
            Force = Force;
            Arrow = Arrow;
            Move = Move;
        }
        public void Force()
        {
            Console.WriteLine("Health increases, increases force");
        }
        public void Arrow(int Kollichestvo)
        {
            Kollichestvo.Arrow = 5;
          Console.WriteLine("+5 arrow");
        }
        public void IMove(string Derection)
        {
            Derection = (left || right);
            Console.WriteLine($"left || right");
        }
    }
}
