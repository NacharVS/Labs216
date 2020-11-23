using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev.strategiya
{
    class fishermens : ICivilian
    {
        public int Zdorove { get; }
        public double Speed { get; private set; }
        public string UnitType { get; } = "земля";

        public fishermens(int zdorove, double speed)
        {
            Zdorove = zdorove;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"движение  {UnitType} скорость : {Speed}");
        }

        public void Work()
        {
            Console.WriteLine($"работает на воде - река,озеро");
        }
    }

    sealed class xunter :  ICivilian
    {
        public double Speed { get; private set; }
        public string UnitType { get; } = "земля";
        public int Zdorove { get; }
        public int Oborona { get; }

        public xunter(int zdorove, int oborona, double speed)
        {
            Zdorove = zdorove;
            Oborona = oborona;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"движение  {UnitType} скорость: {Speed}");
        }

        public void Work()
        {
            Console.WriteLine($"охота за добычей");
        }
    }
    sealed class Shaxter : infa4elovek
    {
        public double Speed { get; private set; }
        public string UnitType { get; } = "земля";
    }
    class shxter : infa4elovek
    {
        public int Zdorove { get; }
        public double Speed { get; private set; }
        public string UnitType { get; } = "земля";

        public shxter(int zdorove, double speed)
        {
            Zdorove = zdorove;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"движение  {UnitType} скорость : {Speed}");
        }

        public void Work()
        {
            Console.WriteLine($"работает под землей ");
        }
    }
}
