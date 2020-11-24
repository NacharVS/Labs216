using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Topunova.Strategy
{
    class Rider : Characteristics, IShoot, IMovable
    {
        public int Shoot => throw new NotImplementedException();
        public int _acceleration;
        public double Speed => throw new NotImplementedException();
        public string _derection;
        public int _health;
        public int _speed;

        public Rider(int Health, int Speed)
        {
            _health = Health;
            _speed = new Speed;
        }
        
        public void ISpead(int Acceleration) //ускорение 
        {
            _acceleration += Acceleration;
            Console.WriteLine($"+{Acceleration}km/h");
        }
        public void IMoves(string Derection) //направление
        {
            _derection = Derection;
            Console.WriteLine($"Выбрать направление: ");
        }
    }
}
