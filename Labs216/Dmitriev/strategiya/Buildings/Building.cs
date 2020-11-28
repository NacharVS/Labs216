using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev.strategiya.Buildings
{
    internal class infa4elovek
    {
        sealed class stena : infaBuilding
        {
            public int Distance { get; private set; }
            public int ShootDamage { get; private set; }

            public stena(int zdorove, int oborona)
            {
                _Zdorove = zdorove;
                _Oborona = oborona;
            }
        }
        public void Interact()
        {
            Console.WriteLine("ПРОХОЖДЕНИЕ ПРЕПЯТСТВИЯ");
        }
    }


    sealed class bshnya : infaBuilding
    {

        public int Distance { get; private set; }
        public int ShootDamage { get; private set; }

        public bshnya(int Zdorove, int Oborona, )
        {
            _Zdorove = Zdorove;
            _Oborona = Oborona;
        }

    }

    public void Interact()
    {
        Console.WriteLine("ПЕРЕМЕЩЕНИЕ ПО БАШНЕ ИЛИ ЖЕ В БАШНЕ ");
    }

    sealed class krepostb : infaBuilding
    {
        public int Distance { get; private set; }
        public int ShootDamage { get; private set; }

        public krepostb(int zdorove, int oborona)
        {
            _Zdorove = zdorove;
            _Oborona = oborona;
        }
    }
    public void Interact()
    {
        Console.WriteLine("ПРОХОЖДЕНИЕ ПРЕПЯТСТВИЯ");
    }
    class LEs
    {
        public int Amount { get; set; }

        public LEs(int amount)
        {
            Amount = amount;
        }
        public void Interact()
        {
            Console.WriteLine($"LEs: {Amount}");
        }
    }
    public class reka
    {
        public int Amount { get; set; }

        public reka(int amount)
        {
            Amount = amount;
        }
        public void Interact()
        {
            Console.WriteLine($"reka: {Amount}");
        }
    }

}

