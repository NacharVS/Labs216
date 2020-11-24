using System;
using System.Collections.Generic;
using System.Text;


namespace Labs216.Topunova.Strategy
{
    class Archer : Characteristics, IShoot, IMovable
    {
        public int Shoot { get; }
        public int _kollichestvo;
        public int _healt;
        public double Speed { get; }
        public int _force;
        public int _move;
        public string _derection;
        public int _arrow;
        public Archer(int Health, int Force, int Arrow, int Move)
        {
            _healt = Health;
            _force = Force;
            _arrow = Arrow;
            _move = Move;
        }
        public void Force()
        {
            Console.WriteLine("Health increases, increases force");
        }
        public void Arrow(int Kollichestvo)
        {
            _kollichestvo += Kollichestvo;
          Console.WriteLine($"+{Kollichestvo} arrow");
        }
        public void IMoves(string Derection)
        {
            _derection = Derection;
            Console.WriteLine($"Выбрать направление: ");
        }
    }
}
