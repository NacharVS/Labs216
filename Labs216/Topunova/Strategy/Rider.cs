using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Topunova.Strategy
{
    class Rider : CharacteristicRider, IShort, IMovable
    {
        public int Shootdmg => throw new NotImplementedException();
        public int adsgdsghs;
        public double Speed => throw new NotImplementedException();

        public Rider(int Health, int Speed)
        {
            Health = Health;
            Speed = Speed;
        }
        {
        public void ISpead(int Acceleration)
        {
            adsgdsghs += Acceleration;
            Console.WriteLine($"+{Acceleration}km/h");
        }
        public void IMoves(string Direction)
        {
            Direction = (left || right);
            Console.WriteLine($"left & right");
        }
    }
}
