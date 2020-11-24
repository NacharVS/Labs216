using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace Labs216.Topunova.Strategy
{
    class Archer : Characteristics, IShort, IMovable
    {
        public int Shootdmg { get; }
        public int afsdgdhdfh;
        public int _healt;
        public double Speed { get; }

        public Archer(int Health, int Force, int Arrow, string IMove)
        {
            _healt = Health;
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
            afsdgdhdfh += Kollichestvo;
          Console.WriteLine($"+{Kollichestvo} arrow");
        }
        public void IMove(string Derection)
        {
            Derection = (left || right);
            Console.WriteLine($"left || right");
        }
    }
}
