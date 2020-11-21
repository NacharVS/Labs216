using System;
using Labs216.Zakirov;
using Labs216.Zakirov.Delegate;
using Labs216.Zakirov.Strategygame;

namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder1 = TeachBuilder();
            IMovable move = builder1;
            move.Move();
            ICreatable create = builder1;
            create.Construct();
        }
        public static Workers.Builder TeachBuilder()
        {
            Workers.Builder builderUnit = new Workers.Builder();
            return builderUnit;
        }
    }    
}
