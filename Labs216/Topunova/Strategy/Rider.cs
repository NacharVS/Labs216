using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Topunova.Strategy
{
    class Rider : CharacteristicRider, ISpead, IMove
    {
        public Rider(int Health, int Speed)
        {
            Health = Health;
            Speed = Speed;
        }
        {
        public void ISpead(Acceleration)
        {
            Acceleration = 5;
            Console.WriteLine("+5km/h");
        }
        public void IMoves(string Direction)
        {
            Direction = (left || right);
            Console.WriteLine($"left & right");
        }
    }
}
